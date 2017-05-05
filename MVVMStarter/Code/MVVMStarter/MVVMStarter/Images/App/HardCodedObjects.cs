using MVVMStarter.Models.Base;

namespace MVVMStarter.Images.App
{
    public class HardCodedObjects : HardCodedObjectsBase<Image>
    {
        public HardCodedObjects()
        {
            string imageFilePrefix = "..\\..\\..\\Assets\\Images\\";

            Image i1 = new Image("Red Sedan", imageFilePrefix + "CarRedSedan.jpg");
            i1.AddTag("Red");
            i1.AddTag("Sedan");
            i1.AddTag("Individual");

            Image i2 = new Image("Blue Combi", imageFilePrefix + "CarBlueCombi.jpg");
            i2.AddTag("Blue");
            i2.AddTag("Combi");
            i2.AddTag("Family");

            Image i3 = new Image("White Mini", imageFilePrefix + "CarWhiteMini.jpg");
            i3.AddTag("White");
            i3.AddTag("Mini");
            i3.AddTag("Family");

            Image i4 = new Image("Green Combi", imageFilePrefix + "CarGreenCombi.jpg");
            i4.AddTag("Green");
            i4.AddTag("Combi");
            i4.AddTag("Family");

            Image i5 = new Image("Purple Sport", imageFilePrefix + "CarPurpleSport.jpg");
            i5.AddTag("Purple");
            i5.AddTag("Sport");
            i5.AddTag("Family");

            Image i6 = new Image("Yellow Sport", imageFilePrefix + "CarYellowSport.jpg");
            i6.AddTag("Yellow");
            i6.AddTag("Sport");
            i6.AddTag("Individual");

            Image i7 = new Image("Black Sedan", imageFilePrefix + "CarBlackSedan.jpg");
            i7.AddTag("Black");
            i7.AddTag("Sedan");
            i7.AddTag("Family");

            Image i8 = new Image("Light Blue Combi", imageFilePrefix + "CarLightBlueCombi.jpg");
            i8.AddTag("Light Blue");
            i8.AddTag("Combi");
            i8.AddTag("Family");

            Image i9 = new Image("Magenta Pickup", imageFilePrefix + "CarMagentaPickup.jpg");
            i9.AddTag("Magenta");
            i9.AddTag("Pickup");
            i9.AddTag("Individual");

            ObjectList.Add(i1);
            ObjectList.Add(i2);
            ObjectList.Add(i3);
            ObjectList.Add(i4);
            ObjectList.Add(i5);
            ObjectList.Add(i6);
            ObjectList.Add(i7);
            ObjectList.Add(i8);
            ObjectList.Add(i9);
        }
    }
}
