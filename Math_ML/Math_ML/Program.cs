using System;

namespace Math_ML
{
    class Program
    {
        class MathMLBuilder // MathML – Mathematical Markup Language.
        {
            private string MathML;
            public MathMLBuilder()
            {
                this.MathML = "";
            }
            public MathMLBuilder beginTag(string value)
            {
                this.MathML += "<" + value + ">\n";
                return this;
            }

            public MathMLBuilder endTag(string value)
            {
                this.MathML += "</" + value + ">";
                return this;
            }
            public MathMLBuilder beginTag2(string value)
            {
                this.MathML += "<" + value + ">";
                return this;
            }
            public MathMLBuilder setContent(string value)
            {
                this.MathML += value;
                return this;
            }
            public MathMLBuilder endTag2(string value)
            {
                this.MathML += "</" + value + ">\n";
                return this;
            }
            public string getMathML()
            {
                return this.MathML;
            }
        }
        static void Main(string[] args)
        {
            MathMLBuilder MathML = new MathMLBuilder();
            string str = MathML.beginTag("math")
                .beginTag("merow")
                .beginTag("merow")
                .beginTag2("mn").setContent("1").endTag2("mn")
                .beginTag2("mo").setContent("+").endTag2("mo")
                .beginTag2("mn").setContent("1").endTag2("mn")
                .endTag2("merow")
                .beginTag2("mo").setContent("=").endTag2("mo")
                .beginTag2("mn").setContent("2").endTag2("mn")
                .endTag2("merow")
                .endTag("math").getMathML();
            Console.Write(str);
        }

    }
}