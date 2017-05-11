using MVVMStarter.Models.Base;

namespace MVVMStarter.Images.App
{
    public class HardCodedObjects : HardCodedObjectsBase<Image>
    {
        public HardCodedObjects()
        {
            string prefix = Configuration.App.AppConfig.ImageFilePrefix;

            #region Car image objects
            Image c1 = new Image("Red Sedan", prefix + "CarRedSedan.jpg");
            c1.AddTag("Car");
            c1.AddTag("Red");
            c1.AddTag("Sedan");
            c1.AddTag("Individual");

            Image c2 = new Image("Blue Combi", prefix + "CarBlueCombi.jpg");
            c2.AddTag("Car");
            c2.AddTag("Blue");
            c2.AddTag("Combi");
            c2.AddTag("Family");

            Image c3 = new Image("White Mini", prefix + "CarWhiteMini.jpg");
            c3.AddTag("Car");
            c3.AddTag("White");
            c3.AddTag("Mini");
            c3.AddTag("Family");

            Image c4 = new Image("Green Combi", prefix + "CarGreenCombi.jpg");
            c4.AddTag("Car");
            c4.AddTag("Green");
            c4.AddTag("Combi");
            c4.AddTag("Family");

            Image c5 = new Image("Purple Sport", prefix + "CarPurpleSport.jpg");
            c5.AddTag("Car");
            c5.AddTag("Purple");
            c5.AddTag("Sport");
            c5.AddTag("Family");

            Image c6 = new Image("Yellow Sport", prefix + "CarYellowSport.jpg");
            c6.AddTag("Car");
            c6.AddTag("Yellow");
            c6.AddTag("Sport");
            c6.AddTag("Individual");

            Image c7 = new Image("Black Sedan", prefix + "CarBlackSedan.jpg");
            c7.AddTag("Car");
            c7.AddTag("Black");
            c7.AddTag("Sedan");
            c7.AddTag("Family");

            Image c8 = new Image("Light Blue Combi", prefix + "CarLightBlueCombi.jpg");
            c8.AddTag("Car");
            c8.AddTag("Light Blue");
            c8.AddTag("Combi");
            c8.AddTag("Family");

            Image c9 = new Image("Magenta Pickup", prefix + "CarMagentaPickup.jpg");
            c9.AddTag("Car");
            c9.AddTag("Magenta");
            c9.AddTag("Pickup");
            c9.AddTag("Individual");

            ObjectList.Add(c1);
            ObjectList.Add(c2);
            ObjectList.Add(c3);
            ObjectList.Add(c4);
            ObjectList.Add(c5);
            ObjectList.Add(c6);
            ObjectList.Add(c7);
            ObjectList.Add(c8);
            ObjectList.Add(c9);
            #endregion

            #region Student image objects
            Image s1 = new Image("Ann", prefix + "Ann.jpg");
            s1.AddTag("Student");
            s1.AddTag("Female");

            Image s2 = new Image("Benny", prefix + "Benny.jpg");
            s2.AddTag("Student");
            s2.AddTag("Male");

            Image s3 = new Image("Carol", prefix + "Carol.jpg");
            s3.AddTag("Student");
            s3.AddTag("Female");

            Image s4 = new Image("Dan", prefix + "Dan.jpg");
            s4.AddTag("Student");
            s4.AddTag("Male");

            Image s5 = new Image("Eliza", prefix + "Eliza.jpg");
            s5.AddTag("Student");
            s5.AddTag("Female");

            ObjectList.Add(s1);
            ObjectList.Add(s2);
            ObjectList.Add(s3);
            ObjectList.Add(s4);
            ObjectList.Add(s5);

            #endregion
        }
    }
}
