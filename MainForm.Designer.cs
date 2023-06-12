namespace BingDownloader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            StartButton = new DataJuggler.Win.Controls.Button();
            CountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            PromptControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            DownloadsFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            RemoveCopyrightCheckbox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            label1 = new Label();
            CloseButtonPoint = new DataJuggler.Win.Controls.LabelTextBoxControl();
            DownloadsButtonPoint = new DataJuggler.Win.Controls.LabelTextBoxControl();
            CloseDownloadsPoint = new DataJuggler.Win.Controls.LabelTextBoxControl();
            CloseDownloadsPoint2 = new DataJuggler.Win.Controls.LabelTextBoxControl();
            DownloadsButtonPoint2 = new DataJuggler.Win.Controls.LabelTextBoxControl();
            CloseButtonPoint2 = new DataJuggler.Win.Controls.LabelTextBoxControl();
            AbortButton = new DataJuggler.Win.Controls.Button();
            OutOfBoostsCheckbox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            BoostsLabel = new Label();
            DownloadYAdjustment = new DataJuggler.Win.Controls.LabelTextBoxControl();
            SuspendLayout();
            // 
            // OutputFolderControl
            // 
            OutputFolderControl.BackColor = Color.Transparent;
            OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            OutputFolderControl.ButtonColor = Color.LemonChiffon;
            OutputFolderControl.ButtonImage = (Image)resources.GetObject("OutputFolderControl.ButtonImage");
            OutputFolderControl.ButtonWidth = 48;
            OutputFolderControl.DarkMode = false;
            OutputFolderControl.DisabledLabelColor = Color.Empty;
            OutputFolderControl.Editable = true;
            OutputFolderControl.EnabledLabelColor = Color.Empty;
            OutputFolderControl.Filter = null;
            OutputFolderControl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputFolderControl.HideBrowseButton = false;
            OutputFolderControl.LabelBottomMargin = 0;
            OutputFolderControl.LabelColor = Color.LemonChiffon;
            OutputFolderControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutputFolderControl.LabelText = "Output Folder:";
            OutputFolderControl.LabelTopMargin = 0;
            OutputFolderControl.LabelWidth = 168;
            OutputFolderControl.Location = new Point(26, 96);
            OutputFolderControl.Name = "OutputFolderControl";
            OutputFolderControl.OnTextChangedListener = null;
            OutputFolderControl.OpenCallback = null;
            OutputFolderControl.ScrollBars = ScrollBars.None;
            OutputFolderControl.SelectedPath = null;
            OutputFolderControl.Size = new Size(805, 32);
            OutputFolderControl.StartPath = null;
            OutputFolderControl.TabIndex = 0;
            OutputFolderControl.TextBoxBottomMargin = 0;
            OutputFolderControl.TextBoxDisabledColor = Color.Empty;
            OutputFolderControl.TextBoxEditableColor = Color.Empty;
            OutputFolderControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputFolderControl.TextBoxTopMargin = 0;
            OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Transparent;
            StartButton.ButtonText = "Start";
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.ForeColor = Color.LemonChiffon;
            StartButton.Location = new Point(711, 395);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(120, 44);
            StartButton.TabIndex = 1;
            StartButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            StartButton.Click += StartButton_Click;
            // 
            // CountControl
            // 
            CountControl.BackColor = Color.Transparent;
            CountControl.BottomMargin = 0;
            CountControl.Editable = true;
            CountControl.Encrypted = false;
            CountControl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CountControl.Inititialized = true;
            CountControl.LabelBottomMargin = 0;
            CountControl.LabelColor = Color.LemonChiffon;
            CountControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CountControl.LabelText = "Count:";
            CountControl.LabelTopMargin = 0;
            CountControl.LabelWidth = 168;
            CountControl.Location = new Point(26, 222);
            CountControl.MultiLine = false;
            CountControl.Name = "CountControl";
            CountControl.OnTextChangedListener = null;
            CountControl.PasswordMode = false;
            CountControl.ScrollBars = ScrollBars.None;
            CountControl.Size = new Size(235, 32);
            CountControl.TabIndex = 2;
            CountControl.TextBoxBottomMargin = 0;
            CountControl.TextBoxDisabledColor = Color.LightGray;
            CountControl.TextBoxEditableColor = Color.White;
            CountControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountControl.TextBoxTopMargin = 0;
            CountControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // PromptControl
            // 
            PromptControl.BackColor = Color.Transparent;
            PromptControl.BottomMargin = 0;
            PromptControl.Editable = true;
            PromptControl.Encrypted = false;
            PromptControl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PromptControl.Inititialized = true;
            PromptControl.LabelBottomMargin = 0;
            PromptControl.LabelColor = Color.LemonChiffon;
            PromptControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PromptControl.LabelText = "Prompt:";
            PromptControl.LabelTopMargin = 0;
            PromptControl.LabelWidth = 168;
            PromptControl.Location = new Point(26, 159);
            PromptControl.MultiLine = false;
            PromptControl.Name = "PromptControl";
            PromptControl.OnTextChangedListener = null;
            PromptControl.PasswordMode = false;
            PromptControl.ScrollBars = ScrollBars.None;
            PromptControl.Size = new Size(805, 32);
            PromptControl.TabIndex = 3;
            PromptControl.TextBoxBottomMargin = 0;
            PromptControl.TextBoxDisabledColor = Color.LightGray;
            PromptControl.TextBoxEditableColor = Color.White;
            PromptControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PromptControl.TextBoxTopMargin = 0;
            PromptControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DownloadsFolderControl
            // 
            DownloadsFolderControl.BackColor = Color.Transparent;
            DownloadsFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            DownloadsFolderControl.ButtonColor = Color.LemonChiffon;
            DownloadsFolderControl.ButtonImage = (Image)resources.GetObject("DownloadsFolderControl.ButtonImage");
            DownloadsFolderControl.ButtonWidth = 48;
            DownloadsFolderControl.DarkMode = false;
            DownloadsFolderControl.DisabledLabelColor = Color.Empty;
            DownloadsFolderControl.Editable = true;
            DownloadsFolderControl.EnabledLabelColor = Color.Empty;
            DownloadsFolderControl.Filter = null;
            DownloadsFolderControl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DownloadsFolderControl.HideBrowseButton = false;
            DownloadsFolderControl.LabelBottomMargin = 0;
            DownloadsFolderControl.LabelColor = Color.LemonChiffon;
            DownloadsFolderControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadsFolderControl.LabelText = "Downloads:";
            DownloadsFolderControl.LabelTopMargin = 0;
            DownloadsFolderControl.LabelWidth = 168;
            DownloadsFolderControl.Location = new Point(26, 33);
            DownloadsFolderControl.Name = "DownloadsFolderControl";
            DownloadsFolderControl.OnTextChangedListener = null;
            DownloadsFolderControl.OpenCallback = null;
            DownloadsFolderControl.ScrollBars = ScrollBars.None;
            DownloadsFolderControl.SelectedPath = null;
            DownloadsFolderControl.Size = new Size(805, 32);
            DownloadsFolderControl.StartPath = null;
            DownloadsFolderControl.TabIndex = 19;
            DownloadsFolderControl.TextBoxBottomMargin = 0;
            DownloadsFolderControl.TextBoxDisabledColor = Color.Empty;
            DownloadsFolderControl.TextBoxEditableColor = Color.Empty;
            DownloadsFolderControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DownloadsFolderControl.TextBoxTopMargin = 0;
            DownloadsFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // RemoveCopyrightCheckbox
            // 
            RemoveCopyrightCheckbox.BackColor = Color.Transparent;
            RemoveCopyrightCheckbox.CheckBoxHorizontalOffSet = 0;
            RemoveCopyrightCheckbox.CheckBoxVerticalOffSet = 3;
            RemoveCopyrightCheckbox.CheckChangedListener = null;
            RemoveCopyrightCheckbox.Checked = true;
            RemoveCopyrightCheckbox.Editable = true;
            RemoveCopyrightCheckbox.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveCopyrightCheckbox.LabelColor = Color.LemonChiffon;
            RemoveCopyrightCheckbox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveCopyrightCheckbox.LabelText = "Remove Bing Copyright:";
            RemoveCopyrightCheckbox.LabelWidth = 260;
            RemoveCopyrightCheckbox.Location = new Point(539, 207);
            RemoveCopyrightCheckbox.Name = "RemoveCopyrightCheckbox";
            RemoveCopyrightCheckbox.Size = new Size(292, 28);
            RemoveCopyrightCheckbox.TabIndex = 20;
            RemoveCopyrightCheckbox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(450, 239);
            label1.Name = "label1";
            label1.Size = new Size(381, 31);
            label1.TabIndex = 21;
            label1.Text = "Take the top 968 pixels and resize to 1,024.";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Visible = false;
            // 
            // CloseButtonPoint
            // 
            CloseButtonPoint.BackColor = Color.Transparent;
            CloseButtonPoint.BottomMargin = 0;
            CloseButtonPoint.Editable = true;
            CloseButtonPoint.Encrypted = false;
            CloseButtonPoint.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButtonPoint.Inititialized = true;
            CloseButtonPoint.LabelBottomMargin = 0;
            CloseButtonPoint.LabelColor = Color.LemonChiffon;
            CloseButtonPoint.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButtonPoint.LabelText = "Close Button:";
            CloseButtonPoint.LabelTopMargin = 0;
            CloseButtonPoint.LabelWidth = 168;
            CloseButtonPoint.Location = new Point(26, 307);
            CloseButtonPoint.MultiLine = false;
            CloseButtonPoint.Name = "CloseButtonPoint";
            CloseButtonPoint.OnTextChangedListener = null;
            CloseButtonPoint.PasswordMode = false;
            CloseButtonPoint.ScrollBars = ScrollBars.None;
            CloseButtonPoint.Size = new Size(235, 32);
            CloseButtonPoint.TabIndex = 22;
            CloseButtonPoint.TextBoxBottomMargin = 0;
            CloseButtonPoint.TextBoxDisabledColor = Color.LightGray;
            CloseButtonPoint.TextBoxEditableColor = Color.White;
            CloseButtonPoint.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButtonPoint.TextBoxTopMargin = 0;
            CloseButtonPoint.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DownloadsButtonPoint
            // 
            DownloadsButtonPoint.BackColor = Color.Transparent;
            DownloadsButtonPoint.BottomMargin = 0;
            DownloadsButtonPoint.Editable = true;
            DownloadsButtonPoint.Encrypted = false;
            DownloadsButtonPoint.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadsButtonPoint.Inititialized = true;
            DownloadsButtonPoint.LabelBottomMargin = 0;
            DownloadsButtonPoint.LabelColor = Color.LemonChiffon;
            DownloadsButtonPoint.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadsButtonPoint.LabelText = "Download Button:";
            DownloadsButtonPoint.LabelTopMargin = 0;
            DownloadsButtonPoint.LabelWidth = 168;
            DownloadsButtonPoint.Location = new Point(26, 357);
            DownloadsButtonPoint.MultiLine = false;
            DownloadsButtonPoint.Name = "DownloadsButtonPoint";
            DownloadsButtonPoint.OnTextChangedListener = null;
            DownloadsButtonPoint.PasswordMode = false;
            DownloadsButtonPoint.ScrollBars = ScrollBars.None;
            DownloadsButtonPoint.Size = new Size(235, 32);
            DownloadsButtonPoint.TabIndex = 23;
            DownloadsButtonPoint.TextBoxBottomMargin = 0;
            DownloadsButtonPoint.TextBoxDisabledColor = Color.LightGray;
            DownloadsButtonPoint.TextBoxEditableColor = Color.White;
            DownloadsButtonPoint.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DownloadsButtonPoint.TextBoxTopMargin = 0;
            DownloadsButtonPoint.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CloseDownloadsPoint
            // 
            CloseDownloadsPoint.BackColor = Color.Transparent;
            CloseDownloadsPoint.BottomMargin = 0;
            CloseDownloadsPoint.Editable = true;
            CloseDownloadsPoint.Encrypted = false;
            CloseDownloadsPoint.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseDownloadsPoint.Inititialized = true;
            CloseDownloadsPoint.LabelBottomMargin = 0;
            CloseDownloadsPoint.LabelColor = Color.LemonChiffon;
            CloseDownloadsPoint.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseDownloadsPoint.LabelText = "Downloads Box:";
            CloseDownloadsPoint.LabelTopMargin = 0;
            CloseDownloadsPoint.LabelWidth = 168;
            CloseDownloadsPoint.Location = new Point(26, 407);
            CloseDownloadsPoint.MultiLine = false;
            CloseDownloadsPoint.Name = "CloseDownloadsPoint";
            CloseDownloadsPoint.OnTextChangedListener = null;
            CloseDownloadsPoint.PasswordMode = false;
            CloseDownloadsPoint.ScrollBars = ScrollBars.None;
            CloseDownloadsPoint.Size = new Size(235, 32);
            CloseDownloadsPoint.TabIndex = 24;
            CloseDownloadsPoint.TextBoxBottomMargin = 0;
            CloseDownloadsPoint.TextBoxDisabledColor = Color.LightGray;
            CloseDownloadsPoint.TextBoxEditableColor = Color.White;
            CloseDownloadsPoint.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseDownloadsPoint.TextBoxTopMargin = 0;
            CloseDownloadsPoint.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CloseDownloadsPoint2
            // 
            CloseDownloadsPoint2.BackColor = Color.Transparent;
            CloseDownloadsPoint2.BottomMargin = 0;
            CloseDownloadsPoint2.Editable = true;
            CloseDownloadsPoint2.Encrypted = false;
            CloseDownloadsPoint2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseDownloadsPoint2.Inititialized = true;
            CloseDownloadsPoint2.LabelBottomMargin = 0;
            CloseDownloadsPoint2.LabelColor = Color.LemonChiffon;
            CloseDownloadsPoint2.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseDownloadsPoint2.LabelText = "Downloads Box:";
            CloseDownloadsPoint2.LabelTopMargin = 0;
            CloseDownloadsPoint2.LabelWidth = 0;
            CloseDownloadsPoint2.Location = new Point(267, 407);
            CloseDownloadsPoint2.MultiLine = false;
            CloseDownloadsPoint2.Name = "CloseDownloadsPoint2";
            CloseDownloadsPoint2.OnTextChangedListener = null;
            CloseDownloadsPoint2.PasswordMode = false;
            CloseDownloadsPoint2.ScrollBars = ScrollBars.None;
            CloseDownloadsPoint2.Size = new Size(80, 32);
            CloseDownloadsPoint2.TabIndex = 25;
            CloseDownloadsPoint2.TextBoxBottomMargin = 0;
            CloseDownloadsPoint2.TextBoxDisabledColor = Color.LightGray;
            CloseDownloadsPoint2.TextBoxEditableColor = Color.White;
            CloseDownloadsPoint2.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseDownloadsPoint2.TextBoxTopMargin = 0;
            CloseDownloadsPoint2.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DownloadsButtonPoint2
            // 
            DownloadsButtonPoint2.BackColor = Color.Transparent;
            DownloadsButtonPoint2.BottomMargin = 0;
            DownloadsButtonPoint2.Editable = true;
            DownloadsButtonPoint2.Encrypted = false;
            DownloadsButtonPoint2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadsButtonPoint2.Inititialized = true;
            DownloadsButtonPoint2.LabelBottomMargin = 0;
            DownloadsButtonPoint2.LabelColor = Color.LemonChiffon;
            DownloadsButtonPoint2.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadsButtonPoint2.LabelText = "Downloads Box:";
            DownloadsButtonPoint2.LabelTopMargin = 0;
            DownloadsButtonPoint2.LabelWidth = 0;
            DownloadsButtonPoint2.Location = new Point(267, 357);
            DownloadsButtonPoint2.MultiLine = false;
            DownloadsButtonPoint2.Name = "DownloadsButtonPoint2";
            DownloadsButtonPoint2.OnTextChangedListener = null;
            DownloadsButtonPoint2.PasswordMode = false;
            DownloadsButtonPoint2.ScrollBars = ScrollBars.None;
            DownloadsButtonPoint2.Size = new Size(80, 32);
            DownloadsButtonPoint2.TabIndex = 26;
            DownloadsButtonPoint2.TextBoxBottomMargin = 0;
            DownloadsButtonPoint2.TextBoxDisabledColor = Color.LightGray;
            DownloadsButtonPoint2.TextBoxEditableColor = Color.White;
            DownloadsButtonPoint2.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DownloadsButtonPoint2.TextBoxTopMargin = 0;
            DownloadsButtonPoint2.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CloseButtonPoint2
            // 
            CloseButtonPoint2.BackColor = Color.Transparent;
            CloseButtonPoint2.BottomMargin = 0;
            CloseButtonPoint2.Editable = true;
            CloseButtonPoint2.Encrypted = false;
            CloseButtonPoint2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButtonPoint2.Inititialized = true;
            CloseButtonPoint2.LabelBottomMargin = 0;
            CloseButtonPoint2.LabelColor = Color.LemonChiffon;
            CloseButtonPoint2.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButtonPoint2.LabelText = "Downloads Box:";
            CloseButtonPoint2.LabelTopMargin = 0;
            CloseButtonPoint2.LabelWidth = 0;
            CloseButtonPoint2.Location = new Point(267, 307);
            CloseButtonPoint2.MultiLine = false;
            CloseButtonPoint2.Name = "CloseButtonPoint2";
            CloseButtonPoint2.OnTextChangedListener = null;
            CloseButtonPoint2.PasswordMode = false;
            CloseButtonPoint2.ScrollBars = ScrollBars.None;
            CloseButtonPoint2.Size = new Size(80, 32);
            CloseButtonPoint2.TabIndex = 27;
            CloseButtonPoint2.TextBoxBottomMargin = 0;
            CloseButtonPoint2.TextBoxDisabledColor = Color.LightGray;
            CloseButtonPoint2.TextBoxEditableColor = Color.White;
            CloseButtonPoint2.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButtonPoint2.TextBoxTopMargin = 0;
            CloseButtonPoint2.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // AbortButton
            // 
            AbortButton.BackColor = Color.Transparent;
            AbortButton.ButtonText = "Abort";
            AbortButton.FlatStyle = FlatStyle.Flat;
            AbortButton.ForeColor = Color.LemonChiffon;
            AbortButton.Location = new Point(585, 395);
            AbortButton.Name = "AbortButton";
            AbortButton.Size = new Size(120, 44);
            AbortButton.TabIndex = 28;
            AbortButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            AbortButton.Click += AbortButton_Click;
            // 
            // OutOfBoostsCheckbox
            // 
            OutOfBoostsCheckbox.BackColor = Color.Transparent;
            OutOfBoostsCheckbox.CheckBoxHorizontalOffSet = 0;
            OutOfBoostsCheckbox.CheckBoxVerticalOffSet = 3;
            OutOfBoostsCheckbox.CheckChangedListener = null;
            OutOfBoostsCheckbox.Checked = false;
            OutOfBoostsCheckbox.Editable = true;
            OutOfBoostsCheckbox.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutOfBoostsCheckbox.LabelColor = Color.LemonChiffon;
            OutOfBoostsCheckbox.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutOfBoostsCheckbox.LabelText = "Out of Boosts:";
            OutOfBoostsCheckbox.LabelWidth = 260;
            OutOfBoostsCheckbox.Location = new Point(539, 277);
            OutOfBoostsCheckbox.Name = "OutOfBoostsCheckbox";
            OutOfBoostsCheckbox.Size = new Size(292, 28);
            OutOfBoostsCheckbox.TabIndex = 29;
            OutOfBoostsCheckbox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // BoostsLabel
            // 
            BoostsLabel.BackColor = Color.Transparent;
            BoostsLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoostsLabel.ForeColor = Color.LemonChiffon;
            BoostsLabel.Location = new Point(353, 308);
            BoostsLabel.Name = "BoostsLabel";
            BoostsLabel.Size = new Size(478, 31);
            BoostsLabel.TabIndex = 30;
            BoostsLabel.Text = "When checked timer increases from 30 to 60 seconds.";
            BoostsLabel.TextAlign = ContentAlignment.TopRight;
            BoostsLabel.Visible = false;
            // 
            // DownloadYAdjustment
            // 
            DownloadYAdjustment.BackColor = Color.Transparent;
            DownloadYAdjustment.BottomMargin = 0;
            DownloadYAdjustment.Editable = true;
            DownloadYAdjustment.Encrypted = false;
            DownloadYAdjustment.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadYAdjustment.Inititialized = true;
            DownloadYAdjustment.LabelBottomMargin = 0;
            DownloadYAdjustment.LabelColor = Color.LemonChiffon;
            DownloadYAdjustment.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DownloadYAdjustment.LabelText = "Downloads Box:";
            DownloadYAdjustment.LabelTopMargin = 0;
            DownloadYAdjustment.LabelWidth = 0;
            DownloadYAdjustment.Location = new Point(353, 357);
            DownloadYAdjustment.MultiLine = false;
            DownloadYAdjustment.Name = "DownloadYAdjustment";
            DownloadYAdjustment.OnTextChangedListener = null;
            DownloadYAdjustment.PasswordMode = false;
            DownloadYAdjustment.ScrollBars = ScrollBars.None;
            DownloadYAdjustment.Size = new Size(80, 32);
            DownloadYAdjustment.TabIndex = 31;
            DownloadYAdjustment.TextBoxBottomMargin = 0;
            DownloadYAdjustment.TextBoxDisabledColor = Color.LightGray;
            DownloadYAdjustment.TextBoxEditableColor = Color.White;
            DownloadYAdjustment.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DownloadYAdjustment.TextBoxTopMargin = 0;
            DownloadYAdjustment.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 451);
            Controls.Add(DownloadYAdjustment);
            Controls.Add(BoostsLabel);
            Controls.Add(OutOfBoostsCheckbox);
            Controls.Add(AbortButton);
            Controls.Add(CloseButtonPoint2);
            Controls.Add(DownloadsButtonPoint2);
            Controls.Add(CloseDownloadsPoint2);
            Controls.Add(CloseDownloadsPoint);
            Controls.Add(DownloadsButtonPoint);
            Controls.Add(CloseButtonPoint);
            Controls.Add(label1);
            Controls.Add(RemoveCopyrightCheckbox);
            Controls.Add(DownloadsFolderControl);
            Controls.Add(PromptControl);
            Controls.Add(CountControl);
            Controls.Add(StartButton);
            Controls.Add(OutputFolderControl);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bing Downloader";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
        private DataJuggler.Win.Controls.Button StartButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl CountControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl PromptControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl DownloadsFolderControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl RemoveCopyrightCheckbox;
        private Label label1;
        private DataJuggler.Win.Controls.LabelTextBoxControl CloseButtonPoint;
        private DataJuggler.Win.Controls.LabelTextBoxControl DownloadsButtonPoint;
        private DataJuggler.Win.Controls.LabelTextBoxControl CloseDownloadsPoint;
        private DataJuggler.Win.Controls.LabelTextBoxControl CloseDownloadsPoint2;
        private DataJuggler.Win.Controls.LabelTextBoxControl DownloadsButtonPoint2;
        private DataJuggler.Win.Controls.LabelTextBoxControl CloseButtonPoint2;
        private DataJuggler.Win.Controls.Button AbortButton;
        private DataJuggler.Win.Controls.LabelCheckBoxControl OutOfBoostsCheckbox;
        private Label BoostsLabel;
        private DataJuggler.Win.Controls.LabelTextBoxControl DownloadYAdjustment;
    }
}