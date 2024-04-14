using AbstractFactory;
using Builder;
using FactoryMethod;
using Prototype;
using Singleton;
using System.Reflection.Emit;

/* Factory Method */
Console.WriteLine("** FactoryMethod **");
string webSubscription = Website.PurchaseSubscription("domestic");
Console.WriteLine(webSubscription);


string appSubscription = MobileApp.PurchaseSubscription("educational");
Console.WriteLine(appSubscription);


string callSubscription = ManagerCall.PurchaseSubscription("premium");
Console.WriteLine(callSubscription);
Console.WriteLine();


                                                                                    /* AbstractFactory */
Console.WriteLine("** Abstract Factory **");
// Створення фабрик для кожного бренду
DeviceFactory iProneFactory = new IProneFactory();
DeviceFactory kiaomiFactory = new KiaomiFactory();
DeviceFactory balaxyFactory = new BalaxyFactory();

// Створення девайсів від кожного бренду
Laptop iProneLaptop = iProneFactory.CreateLaptop();
Netbook kiaomiNetbook = kiaomiFactory.CreateNetbook();
EBook balaxyEBook = balaxyFactory.CreateEBook();
Smartphone iProneSmartphone = iProneFactory.CreateSmartphone();


// Відображення інформації про кожен створений девайс
iProneLaptop.DisplayInfo();
kiaomiNetbook.DisplayInfo();
balaxyEBook.DisplayInfo();
iProneSmartphone.DisplayInfo();
Console.WriteLine();

                                                                                     /* Singleton */
Console.WriteLine("** Singleton **");
// Спроба створити декілька екземплярів класу Authenticator
Authenticator auth1 = Authenticator.GetInstance();
Authenticator auth2 = Authenticator.GetInstance();

// Перевірка, що обидва екземпляри насправді вказують на один і той же об'єкт
Console.WriteLine($"auth1 == auth2: {auth1 == auth2}");

// Використання екземпляра класу Authenticator
auth1.Authenticate("user1", "pass1");
auth2.Authenticate("user2", "pass2");
Console.WriteLine();

                                                                                    /* Prototype */
// Створення вірусів
Virus grandparentVirus = new Virus(10.5, 5, "Grandparent Virus", "Type A");
Virus parentVirus = new Virus(8.2, 3, "Parent Virus", "Type B");
Virus childVirus1 = new Virus(3.5, 1, "Child Virus 1", "Type C");
Virus childVirus2 = new Virus(4.0, 1, "Child Virus 2", "Type D");

// Додавання дітей до батьківських вірусів
grandparentVirus.AddChild(parentVirus);
parentVirus.AddChild(childVirus1);
parentVirus.AddChild(childVirus2);

// Клонування вірусів
Virus clonedGrandparentVirus = (Virus)grandparentVirus.Clone();
Virus clonedParentVirus = (Virus)parentVirus.Clone();

// Відображення інформації про клоновані віруси
Console.WriteLine("Cloned Grandparent Virus:");
clonedGrandparentVirus.DisplayInfo();
Console.WriteLine("\nCloned Parent Virus:");
clonedParentVirus.DisplayInfo();
Console.WriteLine();

                                                                                    /* Builder */

// Керуючий клас для створення персонажів
CharacterDirector director = new CharacterDirector();

// Створення героя
HeroBuilder heroBuilder = new HeroBuilder();
Character hero = director.Construct(heroBuilder);
Console.WriteLine("Hero Character:");
hero.DisplayInfo();
Console.WriteLine();

// Створення ворога
EnemyBuilder enemyBuilder = new EnemyBuilder();
Character enemy = director.Construct(enemyBuilder.AddEvilDeeds(new List<string> { "Stealing", "Lying" }));
Console.WriteLine("Enemy Character:");
enemy.DisplayInfo();
