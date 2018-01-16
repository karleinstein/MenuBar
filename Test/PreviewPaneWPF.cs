namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Forms.Integration;

    [LicenseProvider(typeof(c8501506cd6fad4aa5297d71ae6dcee33)), Description("Displays previews of files like the Windows Explorer in Vista and later OS.")]
    public class PreviewPaneWPF : WindowsFormsHost
    {
        private c0a17c7d0f1b16eb1f1838d3a6c5d3473 c9bb2ff0d23f0793702c8cc977df18ed8 = new c0a17c7d0f1b16eb1f1838d3a6c5d3473();

        static PreviewPaneWPF()
        {
            Type forType = typeof(PreviewPaneWPF);
            Type defaultValue = typeof(PreviewPaneWPF);
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(forType, new FrameworkPropertyMetadata(defaultValue));
        }

        public PreviewPaneWPF()
        {
            Type type = typeof(PreviewPaneWPF);
            LicenseManager.Validate(type, this);
            IntPtr handle = this.c9bb2ff0d23f0793702c8cc977df18ed8.Handle;
            base.Child = this.c9bb2ff0d23f0793702c8cc977df18ed8;
        }

        public bool LoadPreview(string file)
        {
            return this.c9bb2ff0d23f0793702c8cc977df18ed8.c05f0dacb8b5588ae8a5627543481bffd(file);
        }

        public void UnloadPreview()
        {
            this.c9bb2ff0d23f0793702c8cc977df18ed8.ceadbb15fd6543cec4c914bec80a76807();
        }
    }
}

