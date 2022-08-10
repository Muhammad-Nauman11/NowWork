using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainWindow : Form
    {
        public string[] gameTypes = { "Easy", "Medium", "Hard" };
        public string[] timerTypes = {"Count Up","Count Down"};

        //Number of cells in one row or one column
        public int numberOfCellsR;// = 20;
        public int numberOfCellsC;// = 25;
        public int[] minesBoard=new int[] { };
        public int[,] aidNeborFind;
        public string changingGameType;
        public string chagingTimerType;
        public GamePanel gamePanel= new GamePanel();//gamePanel = new GamePanel();
        public int gamePanelW ;
        public int gamePanelH ;
        public string gameEnd;//To know if game ended and how it ended i.e whether game over or game finish
        public int timeInSeconds;
        public string timerType;
        public bool gameStart=false;
        public bool gameJustRun = true;
        public MainWindow()
        {
            InitializeComponent();
            gameTimer.Start();
            cmbTimerType.SelectionLength = 0;
            //gamePanelW = this.Width*4/5;
            //gamePanelH = this.Height*5/6;
        }
            private void MainWindow_Load(object sender, EventArgs e)
        {
            WidgetContainer.Size =this.Size;//Making the size of widget container equal to size of window
            StatusPanel.Width = this.Width;//Making Status Panel width equal to main windows width
            foreach (string gameType in gameTypes) 
            {
                cmbGameType.Items.Add(gameType);
            }
            foreach (string timerType in timerTypes)
            {
                cmbTimerType.Items.Add(timerType);
            }

            cmbGameType.Text = gameTypes[2];
            cmbTimerType.Text = timerTypes[0];
            Bitmap flagImageToResize = new Bitmap(Image.FromFile(@"assets\Flag.png"));
            Image lblFlagFitImage = ResizeImage(flagImageToResize, pictureFlag.Size);//new Size(panelFlag.Size.Height/2, panelFlag.Size.Height/2));
            pictureFlag.Image=lblFlagFitImage;




            Bitmap timerImageToResize = new Bitmap(Image.FromFile(@"assets\Timer.png"));
            Image lblTimerFitImage = ResizeImage(timerImageToResize, pictureTimer.Size);//new Size(panelFlag.Size.Height/2, panelFlag.Size.Height/2));
            pictureTimer.Image = lblTimerFitImage;

            StartGame();
        }


        public void StartGame() 
        {
            gameEnd = "Running";
            gameStart = false;

            changingGameType = cmbGameType.Text;
            switch (changingGameType) 
            {
                case "Easy":
                    numberOfCellsR = 20;
                    numberOfCellsC = 10;
                    timeInSeconds =300;
                    break;
                case "Medium":
                    numberOfCellsR = 20;
                    numberOfCellsC = 25;
                    timeInSeconds = 600;
                    break;
                case "Hard":
                    numberOfCellsR = 25;
                    numberOfCellsC = 50;
                    timeInSeconds = 10;//900;
                    break;
            }

            timerType = cmbTimerType.Text;
            switch (timerType)
            {
                case "Count Up":
                    timeInSeconds = 0;
                    break;
                case "Count Down":
                    break;
            }

            lblTimer.Text = $"{timeInSeconds / 60:00}:{timeInSeconds % 60:00}";
            aidNeborFind =new int[,]{ { -1, -1, -(numberOfCellsC + 1) }, { -1, 0, -numberOfCellsC }, { -1, 1, -(numberOfCellsC - 1) }, { 0, 1, 1 }, { 1, 1, numberOfCellsC + 1 }, { 1, 0, numberOfCellsC }, { 1, -1, numberOfCellsC - 1 }, { 0, -1, -1 } };

            
            minesBoard = new int[numberOfCellsR * numberOfCellsC];
            int numberOfBombs = numberOfCellsC*numberOfCellsR/8;//Calculating number of bombs depending upon the type of game
            lblNumberOfFlag.Text =$"{numberOfBombs}";




            //Bombs Locattions
            var randomGenerator = new Random();
            var bombLocations = Enumerable.Range(0, numberOfCellsR * numberOfCellsC).OrderBy(randomNum => randomGenerator.Next()).Take(numberOfBombs).ToArray();


            //Board Generation
            for (int iCell = 0; iCell < numberOfCellsR * numberOfCellsC; iCell++)
            {
                if (bombLocations.Contains(iCell))
                {
                    minesBoard[iCell] = -1;
                }
                else
                {
                    minesBoard[iCell] = 0;
                }

                        
                }


            //Preparing board to mark locations of cells that have bomb neighbors
            
            for (int iCell = 0; iCell < numberOfCellsR * numberOfCellsC; iCell++)
            {
                if (minesBoard[iCell]!=-1) {
                    int row, col, rowCurrent, colCurrent, nextIndex;
                    rowCurrent = iCell / numberOfCellsC;
                    colCurrent = iCell % numberOfCellsC;


                    for (int iNebIndex = 0; iNebIndex < aidNeborFind.Length/3; iNebIndex++)
                    {
                        row = rowCurrent + aidNeborFind[iNebIndex, 0];
                        col = colCurrent + aidNeborFind[iNebIndex, 1];

                        if (0 <= col && col <= numberOfCellsC - 1 && 0 <= row && row <= numberOfCellsR - 1)
                        {
                                                     
                            nextIndex = iCell + aidNeborFind[iNebIndex, 2];
                            if (minesBoard[nextIndex] == -1)
                            {
                                minesBoard[iCell] += 1;
                            }
                        }
                    }
                }
            }

            DisplayBoard();

        }

        public void DisplayBoard() 
        {
            //WidgetContainer.Controls.Clear();
            
            WidgetContainer.Controls.Add(gamePanel);


            int wCell, hCell;
            if (gameJustRun) 
            {
                gamePanelW = gamePanel.Width;
                gamePanelH = gamePanel.Height;
                gameJustRun = false;
            }
            wCell = gamePanelW / numberOfCellsC;
            hCell = gamePanelH / numberOfCellsR;


            //making width and height of boxes equal
            if (wCell < hCell)
            {
                hCell = wCell;
            }
            else 
            {
                wCell = hCell;
            }


            for (int iCell=0; iCell< minesBoard.Length; iCell++) 
            {
                Button btnCell = new Button();
                btnCell.Size = new Size(wCell, hCell);
                
                
                
                btnCell.Location = new Point((iCell % numberOfCellsC) *wCell, (iCell / numberOfCellsC) *hCell);
                //btnCell.Text=Convert.ToString(minesBoard[iCell]);
                btnCell.Name = $"{minesBoard[iCell]}";
                btnCell.MouseUp += button1_MouseUp;// new EventHandler(button1_MouseUp);
                btnCell.FlatStyle = FlatStyle.Popup;
                btnCell.BackColor =Color.FromArgb(0,180,0);
                
                
                gamePanel.Controls.Add(btnCell);
                
            }

            int windowX, windowY, windowW, windowH;
            windowX = this.Location.X;
            windowY = this.Location.Y;
            windowW = this.Size.Width;
            windowH = this.Size.Height;
            gamePanel.Size = new Size(numberOfCellsC*wCell,numberOfCellsR*hCell);
            gamePanel.Location = new Point(windowX + windowW / 2 - gamePanel.Size.Width / 2, windowY + windowH / 2 - gamePanel.Size.Height / 2);
        }


        private Image ResizeImage(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (Image)b;
        }


        public void DisplayMessage() 
        {
            string message="Game is running" ;
            switch(gameEnd)
            {
                case "Complete":
                    message = "Congratulations, you have sweeped all the mines.";
                    break;
                case "Over":
                    message = "Bombs blast. Game Over";
                    break;
                case "Time Out":
                    message = "Time has Ended. Game Over";
                    break;
            }
            gameStart = false;
            MessageBox.Show(message);
            StartGame();
            
        
        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button btnCell = sender as Button;
            if (gameEnd == "Running") 
            {
                gameStart = true;
                if (e.Button == MouseButtons.Right)
                {
                    if (btnCell.Image == null && Convert.ToInt32(lblNumberOfFlag.Text)!=0)
                    {
                        Bitmap imageToResize = new Bitmap(Image.FromFile(@"assets\Flag.png"));
                        Image btnFitImage = ResizeImage(imageToResize, btnCell.Size);
                        btnCell.Image = btnFitImage;
                        lblNumberOfFlag.Text = $"{Convert.ToInt32(lblNumberOfFlag.Text)-1}";


                    }
                    else 
                    {
                        btnCell.Image = null;
                        lblNumberOfFlag.Text = $"{Convert.ToInt32(lblNumberOfFlag.Text) + 1}";
                    }

                }
                else//left or middle click
                {
                    if (btnCell.Name == "-1") 
                    {

                        Bitmap imageToResize = new Bitmap(Image.FromFile(@"assets\Bomb.png"));
                        Image btnFitImage = ResizeImage(imageToResize, btnCell.Size);
                        foreach (Button btnCellBomb in btnCell.Parent.Controls) 
                        {
                            if (btnCellBomb.Name == "-1") 
                            {

                                btnCellBomb.Image = btnFitImage;
                            }


                        }
                        gameEnd = "Over";
                        
                
                    }
                    else
                    { 
                        Change(btnCell);
                        gameEnd = "Complete";
                        foreach (Button btnCheckEnd in gamePanel.Controls) 
                        {
                            if (btnCheckEnd.Name != "-1" && btnCheckEnd.FlatStyle != FlatStyle.Flat) 
                            {
                                gameEnd = "Running";
                                break;
                            }
                        }
                        if (gameEnd == "Complete") 
                        {
                            DisplayMessage();
                        }
                    }
                }
            }
        }


        public void Change(Button btnCell) 
        {

            Color colorOfCell= Color.FromArgb(128, 64, 0);
            Color textColor = Color.FromArgb(0, 0, 255);
            int numInsideCell = Convert.ToInt32(btnCell.Name);
            switch (numInsideCell) 
            {
                case 0:
                    colorOfCell= Color.FromArgb(200, 200, 180);
                    break;
                case 1:
                    colorOfCell = Color.FromArgb(185, 153, 100);
                    textColor = Color.FromArgb(0, 155, 0);
                    break;
                case 2:
                    colorOfCell = Color.FromArgb(210, 125, 45);
                    textColor = Color.FromArgb(0, 0, 255);
                    break;
                case 3:
                    colorOfCell = Color.FromArgb(184, 115, 51);
                    textColor = Color.FromArgb(25, 50, 150);
                    break;
                case 4:
                    colorOfCell = Color.FromArgb(204, 119, 34);
                    textColor = Color.FromArgb(155, 50, 50);
                    break;
                case 5:
                    colorOfCell = Color.FromArgb(192, 64, 0);
                    textColor = Color.FromArgb(100, 150, 140);
                    break;
                case 6:
                    colorOfCell = Color.FromArgb(123, 63, 0);
                    textColor = Color.FromArgb(200, 0, 50);
                    break;
                case 7:
                    colorOfCell = Color.FromArgb(165, 42, 42);
                    textColor = Color.FromArgb(255, 50, 50);
                    break;
                case 8:
                    colorOfCell = Color.FromArgb(240, 230, 140);
                    textColor= Color.FromArgb(255,0,0);
                    break;
                case -1:
                    colorOfCell = Color.FromArgb(0, 120, 0);
                    break;


            }
            if (numInsideCell != -1) { 
                btnCell.FlatStyle = FlatStyle.Flat;
                btnCell.BackColor = colorOfCell;

                int btnNumber = Convert.ToInt32(btnCell.Parent.Controls.IndexOf(btnCell));

                int row, col, rowCurrent, colCurrent,nextIndex;
                rowCurrent = btnNumber / numberOfCellsC;
                colCurrent = btnNumber % numberOfCellsC;





                if (minesBoard[btnNumber] == 0)
                {
                    for (int iNebIndex = 0; iNebIndex < aidNeborFind.Length / 3; iNebIndex++)
                    {
                        row = rowCurrent + aidNeborFind[iNebIndex, 0];
                        col = colCurrent + aidNeborFind[iNebIndex, 1];

                        if (0 <= col && col <= numberOfCellsC - 1 && 0 <= row && row <= numberOfCellsR - 1)
                        {

                            nextIndex = btnNumber + aidNeborFind[iNebIndex, 2];
                            Button nextBtnCell = btnCell.Parent.Controls[nextIndex] as Button;
                            if (nextBtnCell.FlatStyle != FlatStyle.Flat)
                            {

                                Change(nextBtnCell);
                            }
                            //Task.Delay(3000).ContinueWith(t => change(nextBtnCell));//Calling a function after a specific time in miliseconds

                        }

                    }
                    //btnCell.Text = btnCell.Name;
                }
                else
                {
                    btnCell.Text = $"{minesBoard[btnNumber]}";
                    btnCell.ForeColor = textColor;
                    btnCell.FlatAppearance.BorderColor = Color.Black;
                    btnCell.Font = new Font(btnCell.Font.FontFamily, btnCell.Size.Height/3, FontStyle.Bold);

                }
            }


        }

        private void cmbGameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changingGameType!=cmbGameType.Text) 
            {
                gamePanel.Controls.Clear();
                StartGame();
            }

        }

        private void cmbTimerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timerType != cmbTimerType.Text)
            {
                gamePanel.Controls.Clear();
                StartGame();
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameStart && gameEnd=="Running") 
            {
                if (timerType == "Count Up")
                {
                    timeInSeconds++;
                }
                else 
                {
                    timeInSeconds--;
                    if (timeInSeconds <= 0)
                    {
                        gameEnd = "Time Out";
                        DisplayMessage();
                    }

                }
                lblTimer.Text = $"{timeInSeconds/60:00}:{timeInSeconds%60:00}";
            }
        }
    }
}

