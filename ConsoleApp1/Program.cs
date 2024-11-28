// Серіалізацію / десеріаліція 
// перетворення якогось об'єктку в 
// поток байтів 
// основне призначення - збереження поточного 
// стану об'єкту для подальшого відновлення, чи 
// передачі 

// json / xml

using ConsoleApp1;
using ConsoleApp1.Domain;


#region JSONSerialize
//var OhioPlayers = new Album()
//{
//    Author = "The Black keys",
//    Year = 2024,
//    Genre = "Indy",
//    Name = "Ohio players"
//};

//// 1 спосіб 
////OhioPlayers.Songs = new List<Song>()
////{
////    new() { Name = "This Is Nowhere", Duration = new(0, 0, 0, 0, 3, 45)  },
////    new() { Name = "Don't Let Me Go", Duration = new(0, 0, 0, 0, 2, 35)  },
////    new() { Name = "I Forgot to Be Your Lover", Duration = new( 0, 0, 0, 0, 2, 28)  }
////};

//// 2 cпосіб 

//Song[] songs =
//{
//    new() { Name = "This Is Nowhere", Duration = new DateTime(2000, 1, 1, 0, 3, 45) },
//    new() { Name = "Don't Let Me Go", Duration = new DateTime(2000, 1, 1, 0, 2, 35) },
//    new() { Name = "I Forgot to Be Your Lover", Duration = new DateTime(2000, 1, 1, 0, 2, 28) }
//};
//OhioPlayers.Songs = songs;

//// є проблеми при серіалізації якщо реалізован інтерфейс IEnumarable 


//AlbomManager.Save(AlbomManager.Serialize(OhioPlayers), @"C:\Users\mitch_daniel\Desktop\albom.json");
//string json = AlbomManager.LoadJson(@"C:\Users\mitch_daniel\Desktop\albom.json");
//Album album = AlbomManager.DeserializeJson(json);

//Console.WriteLine(album.Name);
//Console.WriteLine(album.Year);
//Console.WriteLine(album.Author);
//Console.WriteLine(album.Genre);
//foreach (var item in album.Songs)
//{
//    Console.WriteLine(item);
//}
#endregion


#region XMLSerialize
var OhioPlayers = new Album()
{
    Author = "The Black keys",
    Year = 2024,
    Genre = "Indy",
    Name = "Ohio players"
};

OhioPlayers.Songs = new List<Song>()
{
    new() { Name = "This Is Nowhere", Duration = new DateTime(2000, 1, 1, 0, 3, 45)  },
    new() { Name = "Don't Let Me Go", Duration = new DateTime(2000, 1, 1, 0, 2, 35)  },
    new() { Name = "I Forgot to Be Your Lover", Duration = new DateTime(2000, 1, 1, 0, 2, 28)  }
};

AlbomManager.SerializeXML(OhioPlayers, @"C:\Users\mitch_daniel\Desktop\albomXML.xml");


#endregion