namespace Pathfinder_Weather_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weatherTab = new System.Windows.Forms.TabPage();
            this.distScaleLabel = new System.Windows.Forms.Label();
            this.distScaleBox = new System.Windows.Forms.ComboBox();
            this.tempScaleLabel = new System.Windows.Forms.Label();
            this.tempScaleBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.generatorButton = new System.Windows.Forms.Button();
            this.precipitationGroupBox = new System.Windows.Forms.GroupBox();
            this.precIntensityLabel = new System.Windows.Forms.Label();
            this.precIntensityComboBox = new System.Windows.Forms.ComboBox();
            this.precFreqLabel = new System.Windows.Forms.Label();
            this.precFreqComboBox = new System.Windows.Forms.ComboBox();
            this.precipitationLabel = new System.Windows.Forms.Label();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.elevationLabel = new System.Windows.Forms.Label();
            this.elevationComboBox = new System.Windows.Forms.ComboBox();
            this.climateLabel = new System.Windows.Forms.Label();
            this.climateComboBox = new System.Windows.Forms.ComboBox();
            this.tabContro1 = new System.Windows.Forms.TabControl();
            this.dataViewer = new System.Windows.Forms.DataGridView();
            this.dayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloudcoverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windStrengthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfDayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerceptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiscColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weatherTab.SuspendLayout();
            this.precipitationGroupBox.SuspendLayout();
            this.tabContro1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherTab
            // 
            this.weatherTab.Controls.Add(this.distScaleLabel);
            this.weatherTab.Controls.Add(this.distScaleBox);
            this.weatherTab.Controls.Add(this.tempScaleLabel);
            this.weatherTab.Controls.Add(this.tempScaleBox);
            this.weatherTab.Controls.Add(this.clearButton);
            this.weatherTab.Controls.Add(this.generatorButton);
            this.weatherTab.Controls.Add(this.precipitationGroupBox);
            this.weatherTab.Controls.Add(this.seasonLabel);
            this.weatherTab.Controls.Add(this.seasonComboBox);
            this.weatherTab.Controls.Add(this.elevationLabel);
            this.weatherTab.Controls.Add(this.elevationComboBox);
            this.weatherTab.Controls.Add(this.climateLabel);
            this.weatherTab.Controls.Add(this.climateComboBox);
            this.weatherTab.Location = new System.Drawing.Point(4, 22);
            this.weatherTab.Name = "weatherTab";
            this.weatherTab.Padding = new System.Windows.Forms.Padding(3);
            this.weatherTab.Size = new System.Drawing.Size(1021, 145);
            this.weatherTab.TabIndex = 0;
            this.weatherTab.Text = "Weather";
            this.weatherTab.UseVisualStyleBackColor = true;
            // 
            // distScaleLabel
            // 
            this.distScaleLabel.AutoSize = true;
            this.distScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distScaleLabel.Location = new System.Drawing.Point(687, 71);
            this.distScaleLabel.Name = "distScaleLabel";
            this.distScaleLabel.Size = new System.Drawing.Size(116, 20);
            this.distScaleLabel.TabIndex = 14;
            this.distScaleLabel.Text = "Distance Scale";
            // 
            // distScaleBox
            // 
            this.distScaleBox.DisplayMember = "1";
            this.distScaleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distScaleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distScaleBox.FormattingEnabled = true;
            this.distScaleBox.Items.AddRange(new object[] {
            "Imperial",
            "Metric"});
            this.distScaleBox.Location = new System.Drawing.Point(682, 94);
            this.distScaleBox.Name = "distScaleBox";
            this.distScaleBox.Size = new System.Drawing.Size(121, 24);
            this.distScaleBox.Sorted = true;
            this.distScaleBox.TabIndex = 13;
            // 
            // tempScaleLabel
            // 
            this.tempScaleLabel.AutoSize = true;
            this.tempScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempScaleLabel.Location = new System.Drawing.Point(669, 8);
            this.tempScaleLabel.Name = "tempScaleLabel";
            this.tempScaleLabel.Size = new System.Drawing.Size(144, 20);
            this.tempScaleLabel.TabIndex = 12;
            this.tempScaleLabel.Text = "Temperature Scale";
            // 
            // tempScaleBox
            // 
            this.tempScaleBox.DisplayMember = "1";
            this.tempScaleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tempScaleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempScaleBox.FormattingEnabled = true;
            this.tempScaleBox.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
            this.tempScaleBox.Location = new System.Drawing.Point(682, 31);
            this.tempScaleBox.Name = "tempScaleBox";
            this.tempScaleBox.Size = new System.Drawing.Size(121, 24);
            this.tempScaleBox.Sorted = true;
            this.tempScaleBox.TabIndex = 11;
            this.tempScaleBox.SelectedIndexChanged += new System.EventHandler(this.tempScaleBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(929, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 51);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // generatorButton
            // 
            this.generatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatorButton.Location = new System.Drawing.Point(904, 88);
            this.generatorButton.Name = "generatorButton";
            this.generatorButton.Size = new System.Drawing.Size(111, 51);
            this.generatorButton.TabIndex = 9;
            this.generatorButton.Text = "Generate";
            this.generatorButton.UseVisualStyleBackColor = true;
            this.generatorButton.Click += new System.EventHandler(this.generatorButton_Click);
            // 
            // precipitationGroupBox
            // 
            this.precipitationGroupBox.Controls.Add(this.precIntensityLabel);
            this.precipitationGroupBox.Controls.Add(this.precIntensityComboBox);
            this.precipitationGroupBox.Controls.Add(this.precFreqLabel);
            this.precipitationGroupBox.Controls.Add(this.precFreqComboBox);
            this.precipitationGroupBox.Controls.Add(this.precipitationLabel);
            this.precipitationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationGroupBox.Location = new System.Drawing.Point(328, 6);
            this.precipitationGroupBox.Name = "precipitationGroupBox";
            this.precipitationGroupBox.Size = new System.Drawing.Size(296, 128);
            this.precipitationGroupBox.TabIndex = 8;
            this.precipitationGroupBox.TabStop = false;
            // 
            // precIntensityLabel
            // 
            this.precIntensityLabel.AutoSize = true;
            this.precIntensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precIntensityLabel.Location = new System.Drawing.Point(6, 91);
            this.precIntensityLabel.Name = "precIntensityLabel";
            this.precIntensityLabel.Size = new System.Drawing.Size(69, 20);
            this.precIntensityLabel.TabIndex = 10;
            this.precIntensityLabel.Text = "Intensity";
            // 
            // precIntensityComboBox
            // 
            this.precIntensityComboBox.DisplayMember = "1";
            this.precIntensityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.precIntensityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precIntensityComboBox.FormattingEnabled = true;
            this.precIntensityComboBox.Items.AddRange(new object[] {
            "Default",
            "Light",
            "Medium",
            "Heavy",
            "Torrential"});
            this.precIntensityComboBox.Location = new System.Drawing.Point(169, 91);
            this.precIntensityComboBox.Name = "precIntensityComboBox";
            this.precIntensityComboBox.Size = new System.Drawing.Size(121, 24);
            this.precIntensityComboBox.TabIndex = 9;
            // 
            // precFreqLabel
            // 
            this.precFreqLabel.AutoSize = true;
            this.precFreqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precFreqLabel.Location = new System.Drawing.Point(6, 61);
            this.precFreqLabel.Name = "precFreqLabel";
            this.precFreqLabel.Size = new System.Drawing.Size(84, 20);
            this.precFreqLabel.TabIndex = 8;
            this.precFreqLabel.Text = "Frequency";
            // 
            // precFreqComboBox
            // 
            this.precFreqComboBox.DisplayMember = "1";
            this.precFreqComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.precFreqComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precFreqComboBox.FormattingEnabled = true;
            this.precFreqComboBox.Items.AddRange(new object[] {
            "Default",
            "Drought",
            "Rare",
            "Intermittent",
            "Common",
            "Constant"});
            this.precFreqComboBox.Location = new System.Drawing.Point(169, 61);
            this.precFreqComboBox.Name = "precFreqComboBox";
            this.precFreqComboBox.Size = new System.Drawing.Size(121, 24);
            this.precFreqComboBox.TabIndex = 6;
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.AutoSize = true;
            this.precipitationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationLabel.Location = new System.Drawing.Point(89, 25);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(112, 24);
            this.precipitationLabel.TabIndex = 7;
            this.precipitationLabel.Text = "Precipitation";
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonLabel.Location = new System.Drawing.Point(6, 100);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(74, 24);
            this.seasonLabel.TabIndex = 5;
            this.seasonLabel.Text = "Season";
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.DisplayMember = "1";
            this.seasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.seasonComboBox.Location = new System.Drawing.Point(181, 100);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(121, 24);
            this.seasonComboBox.TabIndex = 4;
            // 
            // elevationLabel
            // 
            this.elevationLabel.AutoSize = true;
            this.elevationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevationLabel.Location = new System.Drawing.Point(6, 61);
            this.elevationLabel.Name = "elevationLabel";
            this.elevationLabel.Size = new System.Drawing.Size(87, 24);
            this.elevationLabel.TabIndex = 3;
            this.elevationLabel.Text = "Elevation";
            // 
            // elevationComboBox
            // 
            this.elevationComboBox.DisplayMember = "1";
            this.elevationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elevationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevationComboBox.FormattingEnabled = true;
            this.elevationComboBox.Location = new System.Drawing.Point(181, 61);
            this.elevationComboBox.Name = "elevationComboBox";
            this.elevationComboBox.Size = new System.Drawing.Size(121, 24);
            this.elevationComboBox.Sorted = true;
            this.elevationComboBox.TabIndex = 2;
            // 
            // climateLabel
            // 
            this.climateLabel.AutoSize = true;
            this.climateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.climateLabel.Location = new System.Drawing.Point(6, 23);
            this.climateLabel.Name = "climateLabel";
            this.climateLabel.Size = new System.Drawing.Size(72, 24);
            this.climateLabel.TabIndex = 1;
            this.climateLabel.Text = "Climate";
            // 
            // climateComboBox
            // 
            this.climateComboBox.DisplayMember = "1";
            this.climateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.climateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.climateComboBox.FormattingEnabled = true;
            this.climateComboBox.Location = new System.Drawing.Point(181, 23);
            this.climateComboBox.Name = "climateComboBox";
            this.climateComboBox.Size = new System.Drawing.Size(121, 24);
            this.climateComboBox.Sorted = true;
            this.climateComboBox.TabIndex = 0;
            // 
            // tabContro1
            // 
            this.tabContro1.Controls.Add(this.weatherTab);
            this.tabContro1.Location = new System.Drawing.Point(12, 12);
            this.tabContro1.Name = "tabContro1";
            this.tabContro1.SelectedIndex = 0;
            this.tabContro1.Size = new System.Drawing.Size(1029, 171);
            this.tabContro1.TabIndex = 0;
            // 
            // dataViewer
            // 
            this.dataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayColumn,
            this.temperatureColumn,
            this.cloudcoverColumn,
            this.windStrengthColumn,
            this.eventsColumn,
            this.durationColumn,
            this.timeOfDayColumn,
            this.VisionColumn,
            this.PerceptionColumn,
            this.MiscColumn});
            this.dataViewer.Location = new System.Drawing.Point(12, 189);
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.RowTemplate.Height = 25;
            this.dataViewer.Size = new System.Drawing.Size(1029, 326);
            this.dataViewer.TabIndex = 1;
            // 
            // dayColumn
            // 
            this.dayColumn.HeaderText = "Day";
            this.dayColumn.Name = "dayColumn";
            this.dayColumn.ReadOnly = true;
            this.dayColumn.Width = 50;
            // 
            // temperatureColumn
            // 
            this.temperatureColumn.HeaderText = "Temperature";
            this.temperatureColumn.Name = "temperatureColumn";
            this.temperatureColumn.ReadOnly = true;
            this.temperatureColumn.Width = 70;
            // 
            // cloudcoverColumn
            // 
            this.cloudcoverColumn.HeaderText = "Cloudcover";
            this.cloudcoverColumn.Name = "cloudcoverColumn";
            this.cloudcoverColumn.ReadOnly = true;
            // 
            // windStrengthColumn
            // 
            this.windStrengthColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.windStrengthColumn.HeaderText = "Wind Strength";
            this.windStrengthColumn.Name = "windStrengthColumn";
            this.windStrengthColumn.ReadOnly = true;
            // 
            // eventsColumn
            // 
            this.eventsColumn.HeaderText = "Event";
            this.eventsColumn.Name = "eventsColumn";
            this.eventsColumn.ReadOnly = true;
            // 
            // durationColumn
            // 
            this.durationColumn.HeaderText = "Duration";
            this.durationColumn.Name = "durationColumn";
            this.durationColumn.ReadOnly = true;
            this.durationColumn.Width = 80;
            // 
            // timeOfDayColumn
            // 
            this.timeOfDayColumn.HeaderText = "Time of Day";
            this.timeOfDayColumn.Name = "timeOfDayColumn";
            this.timeOfDayColumn.ReadOnly = true;
            // 
            // VisionColumn
            // 
            this.VisionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VisionColumn.HeaderText = "Vision";
            this.VisionColumn.Name = "VisionColumn";
            this.VisionColumn.ReadOnly = true;
            this.VisionColumn.Width = 60;
            // 
            // PerceptionColumn
            // 
            this.PerceptionColumn.HeaderText = "Perception Ranged Attack Penalties";
            this.PerceptionColumn.Name = "PerceptionColumn";
            this.PerceptionColumn.ReadOnly = true;
            this.PerceptionColumn.Width = 120;
            // 
            // MiscColumn
            // 
            this.MiscColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MiscColumn.HeaderText = "Misc";
            this.MiscColumn.Name = "MiscColumn";
            this.MiscColumn.ReadOnly = true;
            this.MiscColumn.Width = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 527);
            this.Controls.Add(this.dataViewer);
            this.Controls.Add(this.tabContro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pathfinder Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherTab.ResumeLayout(false);
            this.weatherTab.PerformLayout();
            this.precipitationGroupBox.ResumeLayout(false);
            this.precipitationGroupBox.PerformLayout();
            this.tabContro1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage weatherTab;
        private System.Windows.Forms.GroupBox precipitationGroupBox;
        private System.Windows.Forms.Label precIntensityLabel;
        private System.Windows.Forms.ComboBox precIntensityComboBox;
        private System.Windows.Forms.Label precFreqLabel;
        private System.Windows.Forms.ComboBox precFreqComboBox;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Label elevationLabel;
        private System.Windows.Forms.ComboBox elevationComboBox;
        private System.Windows.Forms.Label climateLabel;
        private System.Windows.Forms.ComboBox climateComboBox;
        private System.Windows.Forms.TabControl tabContro1;
        private System.Windows.Forms.Button generatorButton;
        private System.Windows.Forms.DataGridView dataViewer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label tempScaleLabel;
        private System.Windows.Forms.ComboBox tempScaleBox;
        private System.Windows.Forms.Label distScaleLabel;
        private System.Windows.Forms.ComboBox distScaleBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloudcoverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windStrengthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfDayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerceptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiscColumn;
    }
}

