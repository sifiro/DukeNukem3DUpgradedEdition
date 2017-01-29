namespace MegatonEdition2eduke32
{
    partial class Requeriments
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
            this.pb = new System.Windows.Forms.ProgressBar();
            this.l_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 92);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(518, 23);
            this.pb.TabIndex = 0;
            // 
            // l_state
            // 
            this.l_state.AutoSize = true;
            this.l_state.Location = new System.Drawing.Point(9, 40);
            this.l_state.Name = "l_state";
            this.l_state.Size = new System.Drawing.Size(58, 13);
            this.l_state.TabIndex = 1;
            this.l_state.Text = "Esperando";
            // 
            // Requeriments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 142);
            this.Controls.Add(this.l_state);
            this.Controls.Add(this.pb);
            this.Name = "Requeriments";
            this.Text = "Requeriments";
            this.Load += new System.EventHandler(this.Requeriments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label l_state;
    }
}