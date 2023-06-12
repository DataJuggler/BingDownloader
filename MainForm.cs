

#region using statements

using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using DataJuggler.Win.Controls;
using Timer = System.Timers.Timer;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using DataJuggler.PixelDatabase;

#endregion

namespace BingDownloader
{

    #region class MainForm
    /// <summary>
    /// This class is the main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        private string chromeDriverPath;
        private Timer processTimer;
        private IWebDriver chrome;
        private ReadOnlyCollection<IWebElement> webElements;
        private int step;
        private DateTime startTime;
        private int imagesCreated;
        private const int LongDelay = 26000;
        private int ShortDelay = 1800;
        private const string SiteUrl = "https://bing.com/Create";
        private const string SearchBoxId = "sb_form_q";
        private const string CreateButton = "create_btn_c";
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

        #region AbortButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'AbortButton' is clicked.
        /// </summary>
        private void AbortButton_Click(object sender, EventArgs e)
        {
            // End
            Application.Exit();
        }
        #endregion

        #region MainForm_FormClosed(object sender, FormClosedEventArgs e)
        /// <summary>
        /// event is fired when Main Form _ Form Closed
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close
            Application.Exit();
        }
        #endregion

        #region ProcessTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        /// <summary>
        /// event is fired when Timer _ Elapsed
        /// </summary>
        private void ProcessTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Increment the value for Step
            Step++;

            // locals - adjust these as needed for you
            Point downloadButton = new Point(DownloadsButtonPoint.IntValue, DownloadsButtonPoint2.IntValue);
            Point closeButton = new Point(CloseButtonPoint.IntValue, CloseButtonPoint2.IntValue);
            Point closeDownloadsButton = new Point(CloseDownloadsPoint.IntValue, CloseDownloadsPoint2.IntValue);

            // Determine the action by the Step
            switch (Step)
            {
                case 1:

                    // find the searchBox
                    var searchBox = Chrome.FindElement(By.Id(SearchBoxId));

                    // If the searchBox object exists
                    if (NullHelper.Exists(searchBox))
                    {
                        // Clear before sending
                        searchBox.Clear();

                        // Send the Prompt
                        searchBox.SendKeys(PromptControl.Text);
                    }

                    // required
                    break;

                case 2:

                    // find the searchBox
                    var createButton = Chrome.FindElement(By.Id(CreateButton));

                    // If the createButton object exists
                    if (NullHelper.Exists(createButton))
                    {
                        // increase
                        ProcessTimer.Interval = LongDelay;

                        // Click the Create Button
                        createButton.Click();
                    }

                    // required
                    break;

                case 3:

                    // decrease
                    ProcessTimer.Interval = ShortDelay;

                    // find the searchBox
                    WebElements = Chrome.FindElements(By.ClassName("mimg"));

                    // required
                    break;

                case 4:

                    // if there are web elements
                    if (ListHelper.HasOneOrMoreItems(WebElements))
                    {
                        // Click
                        WebElements[0].Click();
                    }

                    // required
                    break;

                case 5:

                    //// find the download button (fail)
                    //List<IWebElement> elements = Chrome.FindElements(By.ClassName("text")).ToList();

                    //if (ListHelper.HasOneOrMoreItems(elements))
                    //{

                    //}

                    // location for Download button for me (zoom 150%). Adjust as needed for your monitor / resolution.
                    Cursor.Position = downloadButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 6:

                    // location for close image button for me
                    Cursor.Position = closeButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 7:

                    // location for close image button for me
                    Cursor.Position = closeDownloadsButton;
                    MouseHelper.MouseClick(Cursor.Position);

                     // required
                    break;

                case 8:

                    // if there are two or more web elements
                    if (ListHelper.HasXOrMoreItems(WebElements, 2))
                    {
                        // Click
                        WebElements[1].Click();
                    }

                    // required
                    break;

                case 9:

                    // location for Download button for me (zoom 150%). Adjust as needed for your monitor / resolution.
                    Cursor.Position = downloadButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 10:

                    // location for close image button for me
                    Cursor.Position = closeButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 11:

                    // location for close image button for me
                    Cursor.Position = closeDownloadsButton;
                    MouseHelper.MouseClick(Cursor.Position);

                     // required
                    break;

                case 12:

                    // if there are two or more web elements
                    if (ListHelper.HasXOrMoreItems(WebElements, 3))
                    {
                        // Click
                        WebElements[2].Click();
                    }

                    // required
                    break;

                case 13:

                    // location for Download button for me (zoom 150%). Adjust as needed for your monitor / resolution.
                    Cursor.Position = downloadButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 14:

                    // location for close image button for me
                    Cursor.Position = closeButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;
                    
                case 15:

                    // location for close image button for me
                    Cursor.Position = closeDownloadsButton;
                    MouseHelper.MouseClick(Cursor.Position);

                     // required
                    break;

                case 16:

                    // if there are two or more web elements
                    if (ListHelper.HasXOrMoreItems(WebElements, 4))
                    {
                        // Click
                        WebElements[3].Click();
                    }

                    // required
                    break;

                case 17:

                    // location for Download button for me (zoom 150%). Adjust as needed for your monitor / resolution.
                    Cursor.Position = downloadButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 18:

                    // location for close image button for me
                    Cursor.Position = closeButton;
                    MouseHelper.MouseClick(Cursor.Position);

                    // required
                    break;

                case 19:

                    // location for close image button for me
                    Cursor.Position = closeDownloadsButton;
                    MouseHelper.MouseClick(Cursor.Position);

                     // required
                    break;

                default:

                    // Increment the value for ImagesCreated
                    ImagesCreated++;

                    // if we are done
                    if (ImagesCreated >= CountControl.IntValue)
                    {
                        // stop the timer
                        ProcessTimer.Stop();

                        // Destroy
                        ProcessTimer.Dispose();

                        // Move the images from the user's download folder to the selected Save Folder
                        MoveImages();
                    }
                    else
                    {
                        // Reset back to zero
                        Step = 0;
                    }

                    // required
                    break;
            }
        }
        #endregion

        #region StartButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'StartButton' is clicked.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Set the time the run starts
            StartTime = DateTime.Now;

            // Reset
            Step = 0;

            // guess
            double charactersPerLine = 45;
            double numberLines = 1;
            double lineHeight = 24;
            double downloadYAdjustment = DownloadYAdjustment.IntValue;

            // set the number of lines
            numberLines = Math.Floor(PromptControl.Text.Length / charactersPerLine) + 1;

            // Set the Y location for the download button
            DownloadsButtonPoint2.Text = (620 + downloadYAdjustment + (numberLines * lineHeight)).ToString();

            // minimize this form
            this.WindowState = FormWindowState.Minimized;

            // Create a new instance of a 'Timer' object.
            ProcessTimer = new Timer();

            // Set the interval
            ProcessTimer.Interval = ShortDelay;
            ProcessTimer.Elapsed += ProcessTimer_Elapsed;
            ProcessTimer.Start();
        }
        #endregion

        #endregion

        #region Methods

        #region Init()
        /// <summary>
        ///  This method performs initializations for this object.
        /// </summary>
        public void Init()
        {
            // Setup the Points - Adjust these as needed
            DownloadsButtonPoint.Text = "1560";
            DownloadsButtonPoint2.Text = "640";
            CloseButtonPoint.Text = "1840";
            CloseButtonPoint2.Text = "184";
            CloseDownloadsPoint.Text = "1900";
            CloseDownloadsPoint2.Text = "1020";

            // This value is added or subtracted to / from the DownloladPoint2 (Y location for the Download Button)
            DownloadYAdjustment.Text = "0";

            // Set the Downloads Folder
            DownloadsFolderControl.Text = KnownFolders.GetPath(KnownFolder.Downloads);

            // Testonly while I am testing
            OutputFolderControl.Text = "C:\\Graphics\\Shirts\\Lemon";
            PromptControl.Text = "lemon, surrealist painting";
            CountControl.Text = "1";

            // Set your ChromeDriverPath
            ChromeDriverPath = "C:\\Projects\\GitHub\\BingDownloader\\chromedriver_win32\\";
            var chromeDriverService = ChromeDriverService.CreateDefaultService(ChromeDriverPath);
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();

            // Create a new instance of a 'ChromeDriver' object.
            Chrome = new ChromeDriver(chromeDriverService, options);

            // Maximize
            Chrome.Manage().Window.Maximize();

            // Go to the Server
            Chrome.Navigate().GoToUrl(SiteUrl);
        }
        #endregion

        #region MoveImages()
        /// <summary>
        /// Move Images
        /// </summary>
        public void MoveImages()
        {
            // Get the .jpg files from the user's downloads folder
            List<string> images = FileHelper.GetFiles(DownloadsFolderControl.Text, ".jpg");

            // local
            int imageNumber = 0;

            // If the images collection exists and has one or more items
            if (ListHelper.HasOneOrMoreItems(images))
            {
                // Iterate the collection of string objects
                foreach (string file in images)
                {
                    // Get the fileInfo
                    FileInfo fileInfo = new FileInfo(file);

                    // if this file was just created
                    if (fileInfo.CreationTime > StartTime)
                    {
                        // Increment the value for imageNumber
                        imageNumber++;

                        // Replace out the Downloads path with the destination path and the new name (image1.jpg for example).
                        string destinationFullName = fileInfo.FullName.Replace(DownloadsFolderControl.Text, OutputFolderControl.Text);
                        string destinationName = "Image" + imageNumber + ".jpg";

                        // Set the fullName
                        destinationFullName = destinationFullName.Replace(fileInfo.Name, destinationName);

                        // Move the file
                        File.Move(fileInfo.FullName, destinationFullName);

                        // verify success
                        if ((File.Exists(destinationFullName)) && (RemoveCopyrightCheckbox.Checked))
                        {
                            // resize
                            PixelDatabase pixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(destinationFullName, null);

                            // If the pixelDatabase object exists
                            if (NullHelper.Exists(pixelDatabase))
                            {
                                // starting point
                                Point point = new Point(1, 1);
                                Rectangle rectangle = new Rectangle(point, new Size(1024, 968));

                                // Create a subimage
                                Bitmap subImage = pixelDatabase.CreateSubImage(point, rectangle);

                                // load a pixel database for the subimage
                                PixelDatabase subImageDB = PixelDatabaseLoader.LoadPixelDatabase(subImage, null);

                                // resize
                                PixelDatabase resizedDB = subImageDB.Resize(1024, 1024);

                                // delete the file
                                File.Delete(destinationFullName);

                                // change the file name to a png
                                destinationFullName = destinationFullName.Replace(".jpg", ".png");

                                // now save the resized image
                                resizedDB.SaveAs(destinationFullName);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Properties

        #region Chrome
        /// <summary>
        /// This property gets or sets the value for 'Chrome'.
        /// </summary>
        public IWebDriver Chrome
        {
            get { return chrome; }
            set { chrome = value; }
        }
        #endregion

        #region ChromeDriverPath
        /// <summary>
        /// This property gets or sets the value for 'ChromeDriverPath'.
        /// </summary>
        public string ChromeDriverPath
        {
            get { return chromeDriverPath; }
            set { chromeDriverPath = value; }
        }
        #endregion

        #region HasChrome
        /// <summary>
        /// This property returns true if this object has a 'Chrome'.
        /// </summary>
        public bool HasChrome
        {
            get
            {
                // initial value
                bool hasChrome = (this.Chrome != null);

                // return value
                return hasChrome;
            }
        }
        #endregion

        #region HasProcessTimer
        /// <summary>
        /// This property returns true if this object has a 'ProcessTimer'.
        /// </summary>
        public bool HasProcessTimer
        {
            get
            {
                // initial value
                bool hasProcessTimer = (this.ProcessTimer != null);

                // return value
                return hasProcessTimer;
            }
        }
        #endregion

        #region ImagesCreated
        /// <summary>
        /// This property gets or sets the value for 'ImagesCreated'.
        /// </summary>
        public int ImagesCreated
        {
            get { return imagesCreated; }
            set { imagesCreated = value; }
        }
        #endregion

        #region ProcessTimer
        /// <summary>
        /// This property gets or sets the value for 'ProcessTimer'.
        /// </summary>
        public Timer ProcessTimer
        {
            get { return processTimer; }
            set { processTimer = value; }
        }
        #endregion

        #region StartTime
        /// <summary>
        /// This property gets or sets the value for 'StartTime'.
        /// </summary>
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        #endregion

        #region Step
        /// <summary>
        /// This property gets or sets the value for 'Step'.
        /// </summary>
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        #endregion

        #region WebElements
        /// <summary>
        /// This property gets or sets the value for 'WebElements'.
        /// </summary>
        public ReadOnlyCollection<IWebElement> WebElements
        {
            get { return webElements; }
            set { webElements = value; }
        }
        #endregion

        #endregion

    }
    #endregion

}
