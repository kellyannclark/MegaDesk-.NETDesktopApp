namespace MegaDesk_KClark
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.nameInput = new System.Windows.Forms.TextBox();
            this.drawerInput = new System.Windows.Forms.NumericUpDown();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.rush = new System.Windows.Forms.Label();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(187, 60);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(200, 20);
            this.nameInput.TabIndex = 0;
            // 
            // drawerInput
            // 
            this.drawerInput.Location = new System.Drawing.Point(187, 177);
            this.drawerInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerInput.Name = "drawerInput";
            this.drawerInput.Size = new System.Drawing.Size(200, 20);
            this.drawerInput.TabIndex = 3;
            // 
            // materialInput
            // 
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.materialInput.Location = new System.Drawing.Point(187, 214);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(200, 21);
            this.materialInput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(166, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(46, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 7;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // width
            // 
            this.width.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Image = ((System.Drawing.Image)(resources.GetObject("width.Image")));
            this.width.Location = new System.Drawing.Point(46, 99);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 8;
            this.width.Text = "Desk Width";
            this.width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depth
            // 
            this.depth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Image = ((System.Drawing.Image)(resources.GetObject("depth.Image")));
            this.depth.Location = new System.Drawing.Point(46, 138);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 20);
            this.depth.TabIndex = 9;
            this.depth.Text = "Desk Depth";
            this.depth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawers
            // 
            this.drawers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawers.Image = ((System.Drawing.Image)(resources.GetObject("drawers.Image")));
            this.drawers.Location = new System.Drawing.Point(46, 177);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(100, 20);
            this.drawers.TabIndex = 10;
            this.drawers.Text = "# of Drawers";
            this.drawers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // material
            // 
            this.material.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.Image = ((System.Drawing.Image)(resources.GetObject("material.Image")));
            this.material.Location = new System.Drawing.Point(46, 215);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(100, 20);
            this.material.TabIndex = 11;
            this.material.Text = "Material";
            this.material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rush
            // 
            this.rush.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rush.Image = ((System.Drawing.Image)(resources.GetObject("rush.Image")));
            this.rush.Location = new System.Drawing.Point(46, 253);
            this.rush.Name = "rush";
            this.rush.Size = new System.Drawing.Size(100, 20);
            this.rush.TabIndex = 12;
            this.rush.Text = "Rush Options";
            this.rush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rushInput
            // 
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "7 days",
            "5 days",
            "3 days"});
            this.rushInput.Location = new System.Drawing.Point(187, 254);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(200, 21);
            this.rushInput.TabIndex = 13;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(187, 99);
            this.widthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(200, 20);
            this.widthInput.TabIndex = 14;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(187, 138);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(200, 20);
            this.depthInput.TabIndex = 15;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.rush);
            this.Controls.Add(this.material);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawerInput);
            this.Controls.Add(this.nameInput);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.NumericUpDown drawerInput;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label rush;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}