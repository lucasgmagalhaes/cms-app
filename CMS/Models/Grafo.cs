using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Grafo
    {
        private object element;
        private List<Grafo> children;

        public Grafo(object element)
        {
            this.element = element;
        }

        public Grafo(List<Grafo> children)
        {
            this.children = children;
        }

        public object Element
        {
            get
            {
                return element;
            }

            set
            {
                element = value;
            }
        }

        public List<Grafo> Children
        {
            get
            {
                return children;
            }

            set
            {
                children = value;
            }
        }
    }
}