
namespace Farm_Maslahatchi.UI_Controls
{
    partial class SynonymsItem_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drugName_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.drugPrice_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // drugName_btn
            // 
            this.drugName_btn.AutoSize = true;
            this.drugName_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drugName_btn.Depth = 0;
            this.drugName_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.drugName_btn.Location = new System.Drawing.Point(0, 0);
            this.drugName_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.drugName_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.drugName_btn.Name = "drugName_btn";
            this.drugName_btn.Primary = false;
            this.drugName_btn.Size = new System.Drawing.Size(213, 48);
            this.drugName_btn.TabIndex = 0;
            this.drugName_btn.Text = "materialFlatButton1";
            this.drugName_btn.UseVisualStyleBackColor = true;
            // 
            // drugPrice_btn
            // 
            this.drugPrice_btn.AutoSize = true;
            this.drugPrice_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drugPrice_btn.Depth = 0;
            this.drugPrice_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.drugPrice_btn.Location = new System.Drawing.Point(309, 0);
            this.drugPrice_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.drugPrice_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.drugPrice_btn.Name = "drugPrice_btn";
            this.drugPrice_btn.Primary = false;
            this.drugPrice_btn.Size = new System.Drawing.Size(213, 48);
            this.drugPrice_btn.TabIndex = 1;
            this.drugPrice_btn.Text = "materialFlatButton2";
            this.drugPrice_btn.UseVisualStyleBackColor = true;
            this.drugPrice_btn.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // SynonymsItem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drugPrice_btn);
            this.Controls.Add(this.drugName_btn);
            this.Name = "SynonymsItem_UC";
            this.Size = new System.Drawing.Size(522, 48);
            this.Load += new System.EventHandler(this.SynonymsItem_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton drugName_btn;
        private MaterialSkin.Controls.MaterialFlatButton drugPrice_btn;
    }
}
