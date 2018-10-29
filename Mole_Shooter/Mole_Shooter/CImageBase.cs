using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mole_Shooter.Properties;
using System.Drawing;
using System.Windows.Forms;


namespace Mole_Shooter
{
    class CImageBase : IDisposable 
    {
        bool disposed = false;
        Bitmap _bitmap;
        private int x;
        private int y;
        public int Left { get { return x;} set { x = value; } }
        public int Top { get { return y; } set { y = value; } }
        public CImageBase(Bitmap _resource)
        {
            _bitmap = new Bitmap(_resource);
        }
        public void DrawImage(Graphics gfx)
        {
            gfx.DrawImage(_bitmap, x, y);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                _bitmap.Dispose();
            }
            disposed = true;
        }

    }
}
