namespace Menu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mensajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensajeToolStripMenuItem,
            this.mensajeToolStripMenuItem1,
            this.textoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mensajeToolStripMenuItem
            // 
            this.mensajeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mensajeToolStripMenuItem.Name = "mensajeToolStripMenuItem";
            this.mensajeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.mensajeToolStripMenuItem.Text = "Ventana";
            this.mensajeToolStripMenuItem.Click += new System.EventHandler(this.mensajeToolStripMenuItem_Click);
            // 
            // mensajeToolStripMenuItem1
            // 
            this.mensajeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidaToolStripMenuItem,
            this.despedidaToolStripMenuItem});
            this.mensajeToolStripMenuItem1.Name = "mensajeToolStripMenuItem1";
            this.mensajeToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.mensajeToolStripMenuItem1.Text = "Mensaje";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.textoToolStripMenuItem.Text = "Texto";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // bienvenidaToolStripMenuItem
            // 
            this.bienvenidaToolStripMenuItem.Name = "bienvenidaToolStripMenuItem";
            this.bienvenidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bienvenidaToolStripMenuItem.Text = "Bienvenida";
            this.bienvenidaToolStripMenuItem.Click += new System.EventHandler(this.bienvenidaToolStripMenuItem_Click);
            // 
            // despedidaToolStripMenuItem
            // 
            this.despedidaToolStripMenuItem.Name = "despedidaToolStripMenuItem";
            this.despedidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.despedidaToolStripMenuItem.Text = "Despedida";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mensajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despedidaToolStripMenuItem;
    }
}

