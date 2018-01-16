namespace LogicNP.ShellObjects
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class WizardPainterClassic : IWizardPainter
    {
        private Font c7cd08c423870476c9f0fa69095905585;
        private Font cfef1be16814f8778f286724a425ad1d3;

        public WizardPainterClassic()
        {
            Font defaultFont = Control.DefaultFont;
            this.cfef1be16814f8778f286724a425ad1d3 = new Font(defaultFont, FontStyle.Bold);
            Font font2 = Control.DefaultFont;
            this.c7cd08c423870476c9f0fa69095905585 = font2;
        }

        internal static void c0470d240de3a4f8bff0de1c774a1a868(ref Rectangle c83ec152583513c05059959145a73174f, ref Rectangle ca7c7d0bcfacebcfb33c7ce81e2958cb9)
        {
            int num15;
            int num = ca7c7d0bcfacebcfb33c7ce81e2958cb9.Width;
            int num2 = ca7c7d0bcfacebcfb33c7ce81e2958cb9.Height;
            int num12 = c83ec152583513c05059959145a73174f.Width;
            if (num <= num12)
            {
                c83ec152583513c05059959145a73174f.Offset((c83ec152583513c05059959145a73174f.Width - num) / 2, 0);
                c83ec152583513c05059959145a73174f.Width = num;
                goto Label_006A;
            }
        Label_001D:
            switch (6)
            {
                case 0:
                    goto Label_001D;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int num13 = c83ec152583513c05059959145a73174f.Width;
                    ca7c7d0bcfacebcfb33c7ce81e2958cb9.X = (num - num13) / 2;
                    int num14 = c83ec152583513c05059959145a73174f.Width;
                    ca7c7d0bcfacebcfb33c7ce81e2958cb9.Width = num14;
                    break;
                }
            }
        Label_006A:
            num15 = c83ec152583513c05059959145a73174f.Height;
            if (num2 > num15)
            {
                ca7c7d0bcfacebcfb33c7ce81e2958cb9.Y = (num2 - c83ec152583513c05059959145a73174f.Height) / 2;
                int num16 = c83ec152583513c05059959145a73174f.Height;
                ca7c7d0bcfacebcfb33c7ce81e2958cb9.Height = num16;
            }
            else
            {
                int num17 = c83ec152583513c05059959145a73174f.Height;
                c83ec152583513c05059959145a73174f.Offset(0, (num17 - num2) / 2);
                c83ec152583513c05059959145a73174f.Height = num2;
            }
        }

        public virtual void PaintButton(WizardPaintButtonEventArgs e)
        {
        }

        public virtual void PaintButtonContainer(WizardPaintEventArgs e)
        {
            Pen controlDark = SystemPens.ControlDark;
            int left = e.ca21346516471988ee8fa7ff8548da071.Left;
            int right = e.ca21346516471988ee8fa7ff8548da071.Right;
            e.cc262ed73696b24e71814781d615231cb.DrawLine(controlDark, left, e.ca21346516471988ee8fa7ff8548da071.Top, right, e.ca21346516471988ee8fa7ff8548da071.Top);
            Pen controlLightLight = SystemPens.ControlLightLight;
            int num3 = e.ca21346516471988ee8fa7ff8548da071.Left;
            int top = e.ca21346516471988ee8fa7ff8548da071.Top;
            e.cc262ed73696b24e71814781d615231cb.DrawLine(controlLightLight, num3, e.ca21346516471988ee8fa7ff8548da071.Top + 1, e.ca21346516471988ee8fa7ff8548da071.Right, top + 1);
            Rectangle rect = e.ca21346516471988ee8fa7ff8548da071;
            rect.Inflate(0, -1);
            rect.Offset(0, 1);
            e.cc262ed73696b24e71814781d615231cb.FillRectangle(SystemBrushes.Control, rect);
        }

        public virtual void PaintPage(WizardPaintEventArgs e)
        {
            Color backColor = e.c1ddc887212aafbd9ba7cb9b75b60e84e.c670e475d239cb644a7575b20d9ccf630.BackColor;
            Brush brush = new SolidBrush(backColor);
            try
            {
                e.cc262ed73696b24e71814781d615231cb.FillRectangle(brush, e.ca21346516471988ee8fa7ff8548da071);
            }
            finally
            {
                if (brush == null)
                {
                    goto Label_0048;
                }
            Label_002F:
                switch (1)
                {
                    case 0:
                        goto Label_002F;

                    default:
                        if (1 == 0)
                        {
                        }
                        brush.Dispose();
                        break;
                }
            Label_0048:;
            }
        }

        public virtual void PaintPageHeader(WizardPaintEventArgs e)
        {
            int num;
            int num2;
            Brush white = Brushes.White;
            e.cc262ed73696b24e71814781d615231cb.FillRectangle(white, e.ca21346516471988ee8fa7ff8548da071);
            WizardPage selectedPage = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
            if (selectedPage.c12a74bd6ba71508a050dd1e73647d36d != null)
            {
                WizardPage page11 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
                int num20 = page11.c12a74bd6ba71508a050dd1e73647d36d.Width;
                WizardPage page12 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
                num = Math.Min(10 + num20, page12.c2c722cb7e32a87966531a1e4c598d61d);
                int num22 = e.ca21346516471988ee8fa7ff8548da071.Width;
                goto Label_0095;
            }
        Label_002C:
            switch (1)
            {
                case 0:
                    goto Label_002C;

                default:
                {
                    if (1 == 0)
                    {
                    }
                    int num19 = e.ca21346516471988ee8fa7ff8548da071.Width;
                    num = 0;
                    break;
                }
            }
        Label_0095:
            if (num <= 0)
            {
                goto Label_0168;
            }
        Label_009C:
            switch (6)
            {
                case 0:
                    goto Label_009C;

                default:
                {
                    int num23 = e.ca21346516471988ee8fa7ff8548da071.Right;
                    int num24 = e.ca21346516471988ee8fa7ff8548da071.Height;
                    Rectangle rectangle = new Rectangle((num23 - num) + 5, e.ca21346516471988ee8fa7ff8548da071.Top + 5, num - 10, num24 - 10);
                    WizardPage page13 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
                    Size size = page13.c12a74bd6ba71508a050dd1e73647d36d.Size;
                    Rectangle rectangle2 = new Rectangle(Point.Empty, size);
                    c0470d240de3a4f8bff0de1c774a1a868(ref rectangle, ref rectangle2);
                    WizardPage page14 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
                    WizardPage page15 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
                    int srcWidth = page15.c12a74bd6ba71508a050dd1e73647d36d.Width;
                    WizardPage page16 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
                    e.cc262ed73696b24e71814781d615231cb.DrawImage(page14.c12a74bd6ba71508a050dd1e73647d36d, rectangle, 0, 0, srcWidth, page16.c12a74bd6ba71508a050dd1e73647d36d.Height, GraphicsUnit.Pixel);
                    break;
                }
            }
        Label_0168:
            num2 = 0x10;
            int num3 = 8;
            int num4 = 15;
            int num5 = 2;
            int width = e.ca21346516471988ee8fa7ff8548da071.Width;
            RectangleF layoutRectangle = new RectangleF((float) num2, (float) num3, (float) ((width - num) - num2), (float) num4);
            StringFormat format = new StringFormat(StringFormatFlags.NoWrap) {
                Trimming = StringTrimming.EllipsisCharacter
            };
            WizardPage page17 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
            Brush black = Brushes.Black;
            e.cc262ed73696b24e71814781d615231cb.DrawString(page17.c924a7adae948f7734a40ae82ec69a136, this.cfef1be16814f8778f286724a425ad1d3, black, layoutRectangle, format);
            int num27 = e.ca21346516471988ee8fa7ff8548da071.Width;
            int height = e.ca21346516471988ee8fa7ff8548da071.Height;
            layoutRectangle = new RectangleF((float) (num2 * 2), (float) (num3 + num4), (float) ((num27 - num) - (num2 * 2)), (float) (((height - num3) - num5) - num4));
            format = new StringFormat();
            WizardPage page18 = e.c1ddc887212aafbd9ba7cb9b75b60e84e.SelectedPage;
            e.cc262ed73696b24e71814781d615231cb.DrawString(page18.c2bbc876fadd7032d696b137bfa5c2a9c, this.c7cd08c423870476c9f0fa69095905585, Brushes.Black, layoutRectangle, format);
            Pen controlDark = SystemPens.ControlDark;
            int left = e.ca21346516471988ee8fa7ff8548da071.Left;
            float bottom = layoutRectangle.Bottom;
            int right = e.ca21346516471988ee8fa7ff8548da071.Right;
            e.cc262ed73696b24e71814781d615231cb.DrawLine(controlDark, (float) left, bottom, (float) right, layoutRectangle.Bottom);
            Pen controlLightLight = SystemPens.ControlLightLight;
            int num31 = e.ca21346516471988ee8fa7ff8548da071.Left;
            float single5 = layoutRectangle.Bottom;
            int num32 = e.ca21346516471988ee8fa7ff8548da071.Right;
            float single6 = layoutRectangle.Bottom;
            e.cc262ed73696b24e71814781d615231cb.DrawLine(controlLightLight, (float) num31, single5 + 1f, (float) num32, single6 + 1f);
        }

        public virtual void PaintPageSideBar(WizardPaintEventArgs e)
        {
            Brush black = Brushes.Black;
            e.cc262ed73696b24e71814781d615231cb.FillRectangle(black, e.ca21346516471988ee8fa7ff8548da071);
        }
    }
}

