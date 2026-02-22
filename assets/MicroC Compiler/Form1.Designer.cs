namespace MicroC_Compiler
{
    partial class MicroC_Compiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicroC_Compiler));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnEdit = new ToolStripMenuItem();
            btnEnableEditing = new ToolStripMenuItem();
            compileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            txtEditor = new TextBox();
            txtOutput = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, btnEdit, compileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            newToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += btnNew;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            openToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += btnOpen;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            saveToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += btnSave;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
            exitToolStripMenuItem.ForeColor = Color.FromArgb(255, 128, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += btnExit;
            // 
            // btnEdit
            // 
            btnEdit.DropDownItems.AddRange(new ToolStripItem[] { btnEnableEditing });
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(42, 21);
            btnEdit.Text = "Edit";
            // 
            // btnEnableEditing
            // 
            btnEnableEditing.BackColor = SystemColors.ActiveCaptionText;
            btnEnableEditing.ForeColor = SystemColors.ControlLightLight;
            btnEnableEditing.Name = "btnEnableEditing";
            btnEnableEditing.Size = new Size(159, 22);
            btnEnableEditing.Text = "Enable Editing";
            btnEnableEditing.Click += btnEnableEd;
            // 
            // compileToolStripMenuItem
            // 
            compileToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compileToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            compileToolStripMenuItem.Size = new Size(68, 21);
            compileToolStripMenuItem.Text = "Compile";
            compileToolStripMenuItem.Click += btnCompile;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 21);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += btnHelp;
            // 
            // txtEditor
            // 
            txtEditor.Dock = DockStyle.Left;
            txtEditor.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditor.Location = new Point(0, 25);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ReadOnly = true;
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.Size = new Size(427, 425);
            txtEditor.TabIndex = 1;
            txtEditor.TextChanged += txtEditor_TextChanged;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.ActiveCaptionText;
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.ForeColor = Color.FromArgb(255, 128, 0);
            txtOutput.Location = new Point(427, 25);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(428, 425);
            txtOutput.TabIndex = 2;
            // 
            // MicroC_Compiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 450);
            Controls.Add(txtOutput);
            Controls.Add(txtEditor);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MicroC_Compiler";
            Text = "MicroC Compiler";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TextBox txtOutput;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem btnEdit;
        private ToolStripMenuItem btnEnableEditing;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox txtEditor;
    }
}
