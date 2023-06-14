using System;
class rectangle : shape { 
    public rectangle(string _getnewcolor, float _getnewheight, float _getnewlength) : base(_getnewcolor, _getnewheight, _getnewlength) {

    }

    public override  float get_Area () {
        return length * height;

    }
    class circle : shape {
        public circle (string _getnewcolor, float _getnewheight,float _getnewlength) : base(_getnewcolor, _getnewheight, _getnewlength) {

        }
    

        }
        public string getSide () {
            return side;
        }
    }
    

}
class shape {
    public float length;
    public float height;

    private  string Color;
    public string getColor () {
        return Color;

    }
    public void setColor (string setnewcolor, float _length, float _height) {
        Color = setnewcolor;
        length = _length;
        height = _height;
        

        

    }
    public shape (string setnewcolor) {
        Color = setnewcolor;
        public void setColor (string setnewcolor) {
            Color = setnewcolor;
        }
        

    }
    public virtual float get_Area () {
        return 
    
    }
        

    }
