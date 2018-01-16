namespace LogicNP.ShellObjects
{
    using System;
    using System.Windows.Forms;

    public class ControlResizeEventArgs : EventArgs
    {
        internal int c0f0b8dd499e68cef6658dcebaf96c6c7;
        internal float c16da6b67f2080cf3857158047d4e8ef8;
        internal System.Windows.Forms.Control c92ec88d675c52bc1fd9422d4e4032352;
        internal ControlResizeSettings c9c2069cd91149a4be8fad8867a7cbde3;
        internal int cba5e657701b90ff0aacc637f0d245bed;
        internal int cd03c605e2371c81d7acc5ae7a1f02fed;
        internal int cd316589d318cf6f1091a8bedc6543c26;

        internal ControlResizeEventArgs(System.Windows.Forms.Control c92ec88d675c52bc1fd9422d4e4032352, int cd03c605e2371c81d7acc5ae7a1f02fed, int cba5e657701b90ff0aacc637f0d245bed, int cd316589d318cf6f1091a8bedc6543c26, int c0f0b8dd499e68cef6658dcebaf96c6c7, float c16da6b67f2080cf3857158047d4e8ef8, ControlResizeSettings c9c2069cd91149a4be8fad8867a7cbde3)
        {
            this.c92ec88d675c52bc1fd9422d4e4032352 = c92ec88d675c52bc1fd9422d4e4032352;
            this.cd03c605e2371c81d7acc5ae7a1f02fed = cd03c605e2371c81d7acc5ae7a1f02fed;
            this.cba5e657701b90ff0aacc637f0d245bed = cba5e657701b90ff0aacc637f0d245bed;
            this.cd316589d318cf6f1091a8bedc6543c26 = cd316589d318cf6f1091a8bedc6543c26;
            this.c0f0b8dd499e68cef6658dcebaf96c6c7 = c0f0b8dd499e68cef6658dcebaf96c6c7;
            this.c16da6b67f2080cf3857158047d4e8ef8 = c16da6b67f2080cf3857158047d4e8ef8;
            this.c9c2069cd91149a4be8fad8867a7cbde3 = c9c2069cd91149a4be8fad8867a7cbde3;
        }

        public System.Windows.Forms.Control Control
        {
            get
            {
                return this.c92ec88d675c52bc1fd9422d4e4032352;
            }
        }

        public float NewFontSize
        {
            get
            {
                return this.c16da6b67f2080cf3857158047d4e8ef8;
            }
            set
            {
                this.c16da6b67f2080cf3857158047d4e8ef8 = value;
            }
        }

        public int NewHeight
        {
            get
            {
                return this.c0f0b8dd499e68cef6658dcebaf96c6c7;
            }
            set
            {
                this.c0f0b8dd499e68cef6658dcebaf96c6c7 = value;
            }
        }

        public int NewLeft
        {
            get
            {
                return this.cd03c605e2371c81d7acc5ae7a1f02fed;
            }
            set
            {
                this.cd03c605e2371c81d7acc5ae7a1f02fed = value;
            }
        }

        public int NewTop
        {
            get
            {
                return this.cba5e657701b90ff0aacc637f0d245bed;
            }
            set
            {
                this.cba5e657701b90ff0aacc637f0d245bed = value;
            }
        }

        public int NewWidth
        {
            get
            {
                return this.cd316589d318cf6f1091a8bedc6543c26;
            }
            set
            {
                this.cd316589d318cf6f1091a8bedc6543c26 = value;
            }
        }

        public ControlResizeSettings ResizerSettings
        {
            get
            {
                return this.c9c2069cd91149a4be8fad8867a7cbde3;
            }
            set
            {
                this.c9c2069cd91149a4be8fad8867a7cbde3 = value;
            }
        }
    }
}

