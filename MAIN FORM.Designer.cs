namespace WindowsFormsApp1
{
    partial class MAIN_FORM
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREATEDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDDEVICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mONITORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Bt_start = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.bt_Send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.List_client = new System.Windows.Forms.ListView();
            this.EndPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mENUToolStripMenuItem,
            this.mODIFYToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREATEDATAToolStripMenuItem,
            this.aDDDEVICEToolStripMenuItem,
            this.mONITORToolStripMenuItem,
            this.hISTORYToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // cREATEDATAToolStripMenuItem
            // 
            this.cREATEDATAToolStripMenuItem.Name = "cREATEDATAToolStripMenuItem";
            this.cREATEDATAToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cREATEDATAToolStripMenuItem.Text = "CREATE DATA";
            // 
            // aDDDEVICEToolStripMenuItem
            // 
            this.aDDDEVICEToolStripMenuItem.Name = "aDDDEVICEToolStripMenuItem";
            this.aDDDEVICEToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aDDDEVICEToolStripMenuItem.Text = "ADD DEVICE";
            // 
            // mONITORToolStripMenuItem
            // 
            this.mONITORToolStripMenuItem.Name = "mONITORToolStripMenuItem";
            this.mONITORToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mONITORToolStripMenuItem.Text = "MODIFY DEVICE";
            // 
            // hISTORYToolStripMenuItem
            // 
            this.hISTORYToolStripMenuItem.Name = "hISTORYToolStripMenuItem";
            this.hISTORYToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.hISTORYToolStripMenuItem.Text = "HISTORY";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // mODIFYToolStripMenuItem
            // 
            this.mODIFYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sERVERToolStripMenuItem,
            this.cOMPORTToolStripMenuItem});
            this.mODIFYToolStripMenuItem.Name = "mODIFYToolStripMenuItem";
            this.mODIFYToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mODIFYToolStripMenuItem.Text = "MODIFY";
            // 
            // sERVERToolStripMenuItem
            // 
            this.sERVERToolStripMenuItem.Name = "sERVERToolStripMenuItem";
            this.sERVERToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sERVERToolStripMenuItem.Text = "SERVER";
            this.sERVERToolStripMenuItem.Click += new System.EventHandler(this.sERVERToolStripMenuItem_Click);
            // 
            // cOMPORTToolStripMenuItem
            // 
            this.cOMPORTToolStripMenuItem.Name = "cOMPORTToolStripMenuItem";
            this.cOMPORTToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cOMPORTToolStripMenuItem.Text = "COMPORT";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANUALToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // mANUALToolStripMenuItem
            // 
            this.mANUALToolStripMenuItem.Name = "mANUALToolStripMenuItem";
            this.mANUALToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mANUALToolStripMenuItem.Text = "MANUAL";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 344);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(760, 114);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Bt_start
            // 
            this.Bt_start.BackColor = System.Drawing.Color.Lime;
            this.Bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Bt_start.Location = new System.Drawing.Point(12, 464);
            this.Bt_start.Name = "Bt_start";
            this.Bt_start.Size = new System.Drawing.Size(154, 85);
            this.Bt_start.TabIndex = 3;
            this.Bt_start.Text = "START";
            this.Bt_start.UseVisualStyleBackColor = false;
            this.Bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.BackColor = System.Drawing.Color.Red;
            this.bt_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Stop.Location = new System.Drawing.Point(172, 464);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(154, 85);
            this.bt_Stop.TabIndex = 4;
            this.bt_Stop.Text = "STOP";
            this.bt_Stop.UseVisualStyleBackColor = false;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bt_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Send.ForeColor = System.Drawing.Color.Black;
            this.bt_Send.Location = new System.Drawing.Point(332, 496);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(440, 53);
            this.bt_Send.TabIndex = 5;
            this.bt_Send.Text = "SEND CMD";
            this.bt_Send.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(332, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 26);
            this.textBox1.TabIndex = 7;
            // 
            // List_client
            // 
            this.List_client.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EndPoint,
            this.ID,
            this.Message,
            this.LastMessage});
            this.List_client.GridLines = true;
            this.List_client.Location = new System.Drawing.Point(12, 27);
            this.List_client.Name = "List_client";
            this.List_client.Size = new System.Drawing.Size(760, 311);
            this.List_client.TabIndex = 8;
            this.List_client.UseCompatibleStateImageBehavior = false;
            this.List_client.View = System.Windows.Forms.View.Details;
            // 
            // EndPoint
            // 
            this.EndPoint.Text = "EndPoint";
            this.EndPoint.Width = 147;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 186;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 233;
            // 
            // LastMessage
            // 
            this.LastMessage.Text = "LastMassege";
            this.LastMessage.Width = 213;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.List_client);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.Bt_start);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MAIN_FORM";
            this.Text = "CONTROL V1.1A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREATEDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDDEVICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mONITORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hISTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANUALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Bt_start;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView List_client;
        private System.Windows.Forms.ColumnHeader EndPoint;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader LastMessage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

