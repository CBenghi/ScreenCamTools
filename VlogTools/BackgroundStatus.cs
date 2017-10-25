using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ScreenCast
{
    public class BackgroundStatus
    {
        public bool Border;
        public int Width;
        public int Height;
        public Point Position;
        public List<string> Contents = new List<string>();
        public int CurrentContent = -1;

        internal void setText(string textValue)
        {
            try
            {
                Contents[CurrentContent] = textValue;
            }
            catch (Exception)
            {
                Contents.Add(textValue);
                CurrentContent = Contents.Count - 1;
            }
        }

        internal string getText(int id)
        {
            try
            {
                CurrentContent = id;
                return Contents[CurrentContent];
            }
            catch (Exception)
            {
                return "";
            }
        }

        internal string getText()
        {
            return getText(this.CurrentContent);
        }

        internal void Insert()
        {
            Contents.Insert(CurrentContent, " ");
        }

        internal void Remove()
        {
            try {
                Contents.RemoveAt(CurrentContent);
                CurrentContent--;
            }
            catch (Exception ex)
            {
            }
        }

        internal void PreviousContent()
        {
            CurrentContent--;
            if (CurrentContent < 0)
                CurrentContent = 0;
        }
        internal void NextContent()
        {
            CurrentContent++;
            if (CurrentContent > Contents.Count)
                CurrentContent = Contents.Count;
        }
    }
}
