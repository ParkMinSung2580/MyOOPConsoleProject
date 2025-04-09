using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOPConsoleProject
{
    public abstract class BaseScene
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Result();

        public virtual void Enter() { }
        public virtual void Exit() { }
    }
}
