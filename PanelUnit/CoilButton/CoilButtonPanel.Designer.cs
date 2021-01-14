
using System.Drawing;

namespace PanelUnit.CoilButton
{
    partial class CoilButtonPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucSignalLamp1 = new Controls.UCSignalLamp();
            this.ucBtnExt1 = new Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // ucSignalLamp1
            // 
            this.ucSignalLamp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSignalLamp1.BackColor = System.Drawing.Color.LightGray;
            this.ucSignalLamp1.IsHighlight = false;
            this.ucSignalLamp1.IsShowBorder = false;
            this.ucSignalLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGray};
            this.ucSignalLamp1.Location = new System.Drawing.Point(82, 2);
            this.ucSignalLamp1.Name = "ucSignalLamp1";
            this.ucSignalLamp1.Size = new System.Drawing.Size(15, 15);
            this.ucSignalLamp1.TabIndex = 1;
            this.ucSignalLamp1.TwinkleSpeed = 0;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.Black;
            this.ucBtnExt1.BtnText = null;
            this.ucBtnExt1.ConerRadius = 15;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBtnExt1.EnabledMouseEffect = true;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.ForeColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(0, 0);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.Black;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(100, 50);
            this.ucBtnExt1.TabIndex = 0;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            // 
            // CoilButtonPanel
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ucSignalLamp1);
            this.Controls.Add(this.ucBtnExt1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(100, 50);
            this.Name = "CoilButtonPanel";
            this.Size = new System.Drawing.Size(100, 50);
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.UCBtnExt ucBtnExt1;
        public Controls.UCSignalLamp ucSignalLamp1;
    }
}
