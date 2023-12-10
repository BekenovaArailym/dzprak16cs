namespace FManagerApp.Forms
{
    partial class CopyForm
    {
       private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label allFilesLabel;
        private System.Windows.Forms.ProgressBar CurrentFileProgressBar;
        private System.Windows.Forms.ProgressBar AllFilesProgressBar;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
    }
}