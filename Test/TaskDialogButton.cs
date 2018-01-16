namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.ComponentModel;

    [TypeConverter("LogicNP.ShellObjects.Design.TaskDialogButtonConverter, LogicNP.ShellObjects.Design")]
    public class TaskDialogButton
    {
        internal TaskDialogButtonList c0aa35ce815935ab7f0962ee1d46d7276;
        internal bool c26b2716da80af4d17377df9e739a6cb8;
        internal bool c3e22d304ab2f63725917ebadf85464b8;
        internal string c60d883365dbc8354eea92b78c4cc9fd4;
        internal int c7a4284401e534c1e7dc8a06c36e68fc8;

        public TaskDialogButton()
        {
            this.c60d883365dbc8354eea92b78c4cc9fd4 = "";
            this.c26b2716da80af4d17377df9e739a6cb8 = true;
            this.c0aa35ce815935ab7f0962ee1d46d7276 = null;
            this.c3e22d304ab2f63725917ebadf85464b8 = false;
        }

        public TaskDialogButton(string buttonText, int buttonId)
        {
            this.c60d883365dbc8354eea92b78c4cc9fd4 = buttonText;
            if (buttonId < 0)
            {
                throw new ArgumentOutOfRangeException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1de1), c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1de6));
            }
            this.c7a4284401e534c1e7dc8a06c36e68fc8 = buttonId;
            this.c26b2716da80af4d17377df9e739a6cb8 = true;
            this.c3e22d304ab2f63725917ebadf85464b8 = false;
        }

        public TaskDialogButton(string buttonText, int buttonId, bool buttonEnable, bool showShield)
        {
            this.c60d883365dbc8354eea92b78c4cc9fd4 = buttonText;
            if (buttonId < 0)
            {
                string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1de6);
                throw new ArgumentOutOfRangeException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1de1), message);
            }
            this.c7a4284401e534c1e7dc8a06c36e68fc8 = buttonId;
            this.c26b2716da80af4d17377df9e739a6cb8 = buttonEnable;
            this.c3e22d304ab2f63725917ebadf85464b8 = showShield;
        }

        public bool Enabled
        {
            get
            {
                return this.c26b2716da80af4d17377df9e739a6cb8;
            }
            set
            {
                this.c26b2716da80af4d17377df9e739a6cb8 = value;
                if (!this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.cdb7e066127928502625fa04cf87a7dfe)
                {
                    return;
                }
            Label_001C:
                switch (6)
                {
                    case 0:
                        goto Label_001C;

                    default:
                        if (1 == 0)
                        {
                        }
                        if (this.c0aa35ce815935ab7f0962ee1d46d7276.cbcc29305acb8587517352e24ae66d7bd != c88e400412b44b6ea1d6403711ecbcac3.c480d2efaec198d4b69c63f9c845a83f8)
                        {
                            if (this.c0aa35ce815935ab7f0962ee1d46d7276.cbcc29305acb8587517352e24ae66d7bd != c88e400412b44b6ea1d6403711ecbcac3.c752e71ad2deef47c9447e28faeb5d938)
                            {
                                return;
                            }
                        Label_0074:
                            switch (1)
                            {
                                case 0:
                                    goto Label_0074;
                            }
                            int iD = this.ID;
                            this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.c4834587c0c181e228fe9a841e71499bd(iD, this.c26b2716da80af4d17377df9e739a6cb8);
                            return;
                        }
                        break;
                }
            Label_003D:
                switch (7)
                {
                    case 0:
                        goto Label_003D;

                    default:
                    {
                        int num3 = this.ID;
                        this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.c0cf120918c08d930acee2d3080a237d5(num3, this.c26b2716da80af4d17377df9e739a6cb8);
                        return;
                    }
                }
            }
        }

        public int ID
        {
            get
            {
                return this.c7a4284401e534c1e7dc8a06c36e68fc8;
            }
            set
            {
                if (this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.cdb7e066127928502625fa04cf87a7dfe)
                {
                    string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x182b);
                    throw new InvalidOperationException(message);
                }
                if (value >= 0)
                {
                    this.c7a4284401e534c1e7dc8a06c36e68fc8 = value;
                    return;
                }
            Label_0028:
                switch (1)
                {
                    case 0:
                        goto Label_0028;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentOutOfRangeException(c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1de1), c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x1de6));
            }
        }

        public bool ShowShieldIcon
        {
            get
            {
                return this.c3e22d304ab2f63725917ebadf85464b8;
            }
            set
            {
                this.c3e22d304ab2f63725917ebadf85464b8 = value;
                if (!this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.cdb7e066127928502625fa04cf87a7dfe)
                {
                    return;
                }
            Label_0019:
                switch (3)
                {
                    case 0:
                        goto Label_0019;

                    default:
                    {
                        if (1 == 0)
                        {
                        }
                        int iD = this.ID;
                        this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.c4e2064cfb2fa050b7ea297244f6abaa3(iD, this.c3e22d304ab2f63725917ebadf85464b8);
                        break;
                    }
                }
            }
        }

        public string Text
        {
            get
            {
                return this.c60d883365dbc8354eea92b78c4cc9fd4;
            }
            set
            {
                if (!this.c0aa35ce815935ab7f0962ee1d46d7276.c7ff050d39cb2d26403eca2ee39bdd6bf.cdb7e066127928502625fa04cf87a7dfe)
                {
                    this.c60d883365dbc8354eea92b78c4cc9fd4 = value;
                    return;
                }
            Label_0012:
                switch (2)
                {
                    case 0:
                        goto Label_0012;
                }
                if (1 == 0)
                {
                }
                string message = c0bbbfa1d3eac60244be07cb7c7058941.c47c07faa149539febe2a8e1f978fa8dd(0x182b);
                throw new InvalidOperationException(message);
            }
        }
    }
}

