﻿namespace FireEmblemHeroes
{
  partial class MainForm
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
      this.timerInvalidate = new System.Windows.Forms.Timer(this.components);
      this.pnlCanvas = new System.Windows.Forms.PanelDb();
      this.SuspendLayout();
      // 
      // timerInvalidate
      // 
      this.timerInvalidate.Interval = 60;
      this.timerInvalidate.Tick += new System.EventHandler(this.timerInvalidate_Tick);
      // 
      // pnlCanvas
      // 
      this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlCanvas.Location = new System.Drawing.Point(10, 10);
      this.pnlCanvas.Name = "pnlCanvas";
      this.pnlCanvas.Size = new System.Drawing.Size(510, 570);
      this.pnlCanvas.TabIndex = 0;
      this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(530, 590);
      this.Controls.Add(this.pnlCanvas);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PanelDb pnlCanvas;
    private System.Windows.Forms.Timer timerInvalidate;
  }
}

