Using Area;

public class shape  {
    string Set_Color  = "blue";
    public void Set_newColor(string color) {
        Set_Color = color;
        




    }
    public shape () {
            string Get_color = "get new color";
        


    }

        public string Get_color () {
            return Set_Color;
        }
        public virtual float Get_Area (int length, int height) {

            return length * height; 
        }
      
        // public void Get_Area(string area){
        //     get
        // }
}

