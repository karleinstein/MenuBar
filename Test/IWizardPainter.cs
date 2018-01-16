namespace LogicNP.ShellObjects
{
    using System;

    public interface IWizardPainter
    {
        void PaintButton(WizardPaintButtonEventArgs e);
        void PaintButtonContainer(WizardPaintEventArgs e);
        void PaintPage(WizardPaintEventArgs e);
        void PaintPageHeader(WizardPaintEventArgs e);
        void PaintPageSideBar(WizardPaintEventArgs e);
    }
}

