namespace LogicNP.ShellObjects
{
    using A;
    using System;
    using System.Collections;
    using System.Reflection;

    public class TaskDialogButtonList : IList, ICollection, IEnumerable
    {
        private ArrayList c756720859f388dc2ba9489ffae9af330 = new ArrayList(5);
        internal c9f3e51e839cf41991f6e84afc4c0b030 c7ff050d39cb2d26403eca2ee39bdd6bf;
        internal c88e400412b44b6ea1d6403711ecbcac3 cbcc29305acb8587517352e24ae66d7bd;

        internal TaskDialogButtonList(c9f3e51e839cf41991f6e84afc4c0b030 c46fb69bf180ad628f08afed0e88bc1e0)
        {
            this.c7ff050d39cb2d26403eca2ee39bdd6bf = c46fb69bf180ad628f08afed0e88bc1e0;
        }

        public int Add(TaskDialogButton button)
        {
            int num = this.c756720859f388dc2ba9489ffae9af330.Add(button);
            button.c0aa35ce815935ab7f0962ee1d46d7276 = this;
            return num;
        }

        private int c4923e31f428abc830296a78c6a36865b(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            return this.Add(cfb2f2abc8e61232ab9b3563c7fc6acf6 as TaskDialogButton);
        }

        private int c5e43e45bee532cdd27726bb75e4459d1(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            return this.IndexOf(cfb2f2abc8e61232ab9b3563c7fc6acf6 as TaskDialogButton);
        }

        private bool c783bad4206caef4ecefda2449461ebe4(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            return this.Contains(cfb2f2abc8e61232ab9b3563c7fc6acf6 as TaskDialogButton);
        }

        private void c8322884c79f79a1c3f618fa8911cba9b(object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            this.Remove(cfb2f2abc8e61232ab9b3563c7fc6acf6 as TaskDialogButton);
        }

        private void cf6b4e86f956cb4251eee177bc81b012a(int cf0836916dccce7c844b0870aa147ff01, object cfb2f2abc8e61232ab9b3563c7fc6acf6)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            int count = this.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                this.RemoveAt(i);
            }
        }

        public bool Contains(TaskDialogButton tbutton)
        {
            int index = this.IndexOf(tbutton);
            return (index != -1);
        }

        public void CopyTo(Array array, int index)
        {
            this.c756720859f388dc2ba9489ffae9af330.CopyTo(array, index);
        }

        public void Dispose()
        {
            this.c756720859f388dc2ba9489ffae9af330 = null;
        }

        public IEnumerator GetEnumerator()
        {
            return this.c756720859f388dc2ba9489ffae9af330.GetEnumerator();
        }

        public int IndexOf(TaskDialogButton tbutton)
        {
            return this.c756720859f388dc2ba9489ffae9af330.IndexOf(tbutton);
        }

        public void Remove(TaskDialogButton tbutton)
        {
            int num = this.IndexOf(tbutton);
            if (num == -1)
            {
                return;
            }
        Label_000E:
            switch (5)
            {
                case 0:
                    goto Label_000E;

                default:
                    if (1 == 0)
                    {
                    }
                    this.RemoveAt(num);
                    break;
            }
        }

        public void RemoveAt(int index)
        {
            int count = this.Count;
            if (index < count)
            {
                this.c756720859f388dc2ba9489ffae9af330.RemoveAt(index);
                return;
            }
        Label_000B:
            switch (6)
            {
                case 0:
                    goto Label_000B;
            }
            if (1 == 0)
            {
            }
            throw new ArgumentOutOfRangeException();
        }

        private object this[int cf0836916dccce7c844b0870aa147ff01]
        {
            get
            {
                return this[cf0836916dccce7c844b0870aa147ff01];
            }
            set
            {
                this[cf0836916dccce7c844b0870aa147ff01] = value as TaskDialogButton;
            }
        }

        public int Count
        {
            get
            {
                return this.c756720859f388dc2ba9489ffae9af330.Count;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public TaskDialogButton this[int index]
        {
            get
            {
                int count = this.Count;
                if (index < count)
                {
                    object obj2 = this.c756720859f388dc2ba9489ffae9af330[index];
                    return (TaskDialogButton) obj2;
                }
            Label_000B:
                switch (2)
                {
                    case 0:
                        goto Label_000B;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                int count = this.Count;
                if (index < count)
                {
                    this.c756720859f388dc2ba9489ffae9af330[index] = value;
                    return;
                }
            Label_000B:
                switch (1)
                {
                    case 0:
                        goto Label_000B;
                }
                if (1 == 0)
                {
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public object SyncRoot
        {
            get
            {
                return null;
            }
        }

        [__DynamicallyInvokable]
        private object this[int index]
        {
            get
            {
                return this[cf0836916dccce7c844b0870aa147ff01];
            }
            set
            {
                this[cf0836916dccce7c844b0870aa147ff01] = value as TaskDialogButton;
            }
        }
    }
}

