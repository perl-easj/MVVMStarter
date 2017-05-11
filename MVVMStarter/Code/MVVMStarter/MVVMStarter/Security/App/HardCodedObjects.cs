using MVVMStarter.Models.Base;

namespace MVVMStarter.Security.App
{
    public class HardCodedObjects : HardCodedObjectsBase<User>
    {
        public HardCodedObjects()
        {
            User user0 = new User(User.AdminName, User.AdminPassword);

            User user1 = new User("one", "1");
            user1.Add("CarView", ItemAccess.AccessType.Read);
            user1.Add("CustomerView", ItemAccess.AccessType.Read);
            user1.Add("EmployeeView", ItemAccess.AccessType.Full);

            User user2 = new User("two", "2");
            user2.Add("CarView", ItemAccess.AccessType.Read);
            user2.Add("CarView", ItemAccess.AccessType.Update);
            user2.Add("CustomerView", ItemAccess.AccessType.Full);

            User user3 = new User("three", "3");
            user3.Add("CarView", ItemAccess.AccessType.Full);
            user3.Add("CustomerView", ItemAccess.AccessType.Read);
            user3.Add("SaleView", ItemAccess.AccessType.Read);
            user3.Add("SaleView", ItemAccess.AccessType.Delete);

            User user4 = new User("four", "4");
            user4.Add("EmployeeView", ItemAccess.AccessType.Read);
            user4.Add("SaleView", ItemAccess.AccessType.Full);

            ObjectList.Add(user0);
            ObjectList.Add(user1);
            ObjectList.Add(user2);
            ObjectList.Add(user3);
            ObjectList.Add(user4);
        }
    }
}