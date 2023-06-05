# A very simple Flask Hello World app for you to get started with...

from flask import Flask
from flask import request, jsonify
import json
import time
import datetime
app = Flask(__name__)


movie = [
  {
    "MovieName": "Shazam! Fury of the Gods",
    "ImagePath": "/images/shazamCover.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "12+",
    "MovieFormat": "2D",
    "MovieLanguages": "TR EN RU",
    "MovieCondition": "soon",
    "MovieCountry": "USA",
    "MovieDirector": "David F. Sandberg",
    "MovieGenre": "Fantasy, Action, Thriller, Comedy, Crime, Adventure",
    "MovieActors": "Grace Caroline Currey Zachary Levi Helen Mirren",
    "MovieDuration": "02:10:00",
    "Theater": None,
    "About": "The film continues the story of teenage Billy Batson who, upon reciting the magic word \"SHAZAM!\" is transformed into his adult Super Hero alter ego, Shazam.",
    "MovieYear": 2022,
    "MovieLink": "https://www.youtube.com/watch?v=Zi88i4CpHe4",
    "Rating": 7.0,
    "MoviePrice": 80000,
    "Id": 1
  },
  {
    "MovieName": "Forever",
    "ImagePath": "/images/foreverCover.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN TR",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Matthew Miller",
    "MovieGenre": "Crime, Drama, Fantasy, Mystery, Sci-Fi",
    "MovieActors": "Ioan GruffuddAlana De La GarzaJoel David Moore",
    "MovieDuration": "02:10:00",
    "Theater": None,
    "About": "A 200-year-old man works in the New York City Morgue trying to find a key to unlock the curse of his immortality.",
    "MovieYear": 2014,
    "MovieLink": "https://www.youtube.com/watch?v=-JmVnyJ16d4",
    "Rating": 8.2,
    "MoviePrice": 90000,
    "Id": 2
  },
  {
    "MovieName": "The LockSmith",
    "ImagePath": "/images/theLockSmith.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "RU",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Nicolas Harvard",
    "MovieGenre": "Action, Mystery, Thriller",
    "MovieActors": "Kate Bosworth Ryan Phillippe Jeffrey Nordling",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "A thief fresh out of prison, tries to work his way back into the life of his daughter and ex-fiancé. Determined, he is forced to use the skills he has as a gifted locksmith. Things take a tumultuous turn after an unexpected disappearance.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=tfAg2ylTqPo",
    "Rating": 4.7,
    "MoviePrice": 90000,
    "Id": 3
  },
  {
    "MovieName": "Epic Tales",
    "ImagePath": "/images/epicTales.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "6+",
    "MovieFormat": "2D",
    "MovieLanguages": "RU",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "David Alaux, Eric Tosti, Jean-François Tosti",
    "MovieGenre": "Animation, Adventure, Comedy",
    "MovieActors": "Kate Bosworth Ryan Phillippe Jeffrey Nordling",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "Life in Yolcos, a beautiful and prosperous port city in ancient Greece, is peaceful until the population is threatened by the wrath of Poseidon. A young, adventurous mouse and the cat who adopted her help the aged Jason and his Argonauts in their quest to save the city.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=UzHilzZX7iw",
    "Rating": 6.0,
    "MoviePrice": 60000,
    "Id": 4
  },
  {
    "MovieName": "Scream 6",
    "ImagePath": "/images/scream.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "18+",
    "MovieFormat": "2D",
    "MovieLanguages": "RU EN",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Matt Bettinelli-Olpin, Tyler Gillett",
    "MovieGenre": "Horror, Mystery, Thriller",
    "MovieActors": "Melissa Barrera Jenna Ortega Courteney Cox",
    "MovieDuration": "02:10:00",
    "Theater": None,
    "About": "In the next installment, the survivors of the Ghostface killings leave Woodsboro behind and start a fresh chapter in New York City.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=h74AXqw4Opc",
    "Rating": 7.2,
    "MoviePrice": 80000,
    "Id": 5
  },
  {
    "MovieName": "65",
    "ImagePath": "/images/65.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN RU",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Scott Beck, Bryan Woods",
    "MovieGenre": "Adventure, Drama, Sci-Fi",
    "MovieActors": "Adam Driver Ariana Greenblatt Chloe Coleman",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "An astronaut crash lands on a mysterious planet only to discover he's not alone.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=bHXejJq5vr0",
    "Rating": 5.6,
    "MoviePrice": 80000,
    "Id": 7
  },
  {
    "MovieName": "Cocaine Bear",
    "ImagePath": "/images/cocaineBear.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "18+",
    "MovieFormat": "2D",
    "MovieLanguages": "RU",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Elizabeth Banks",
    "MovieGenre": "Comedy, Thriller",
    "MovieActors": "Keri RussellAlden Ehrenreich O'Shea Jackson Jr",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "An oddball group of cops, criminals, tourists and teens converge on a Georgia forest where a huge black bear goes on a murderous rampage after unintentionally ingesting cocaine.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=DuWEEKeJLMI",
    "Rating": 6.1,
    "MoviePrice": 80000,
    "Id": 8
  },
  {
    "MovieName": "Ant-Man and the Wasp: Quantumania",
    "ImagePath": "/images/antMan.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "12+",
    "MovieFormat": "3D / 2D",
    "MovieLanguages": "RU TR",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Peyton Reed",
    "MovieGenre": "Action, Adventure, Comedy",
    "MovieActors": "Kathryn Newton Jonathan Majors Evangeline Lilly",
    "MovieDuration": "02:10:00",
    "Theater": None,
    "About": "Scott Lang and Hope Van Dyne, along with Hank Pym and Janet Van Dyne, explore the Quantum Realm, where they interact with strange creatures and embark on an adventure that goes beyond the limits of what they thought was possible.",
    "MovieYear": 2022,
    "MovieLink": "https://www.youtube.com/watch?v=5WfTEZJnv_8",
    "Rating": 6.4,
    "MoviePrice": 80000,
    "Id": 9
  },
  {
    "MovieName": "Prestij Meselesi",
    "ImagePath": "/images/prestijCover.png",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "12+",
    "MovieFormat": "2D",
    "MovieLanguages": "TR",
    "MovieCondition": "today",
    "MovieCountry": "Turkey",
    "MovieDirector": "Mahsun Kırmızıgül",
    "MovieGenre": "Drama",
    "MovieActors": "Biran Damla Yilmaz Melisa Döngel Erkan Petekkaya",
    "MovieDuration": "02:10:00",
    "Theater": None,
    "About": "Film tells the story of the legendary music label in the 1990s, where Mahsun and many other stars like Özcan Deniz became superstars.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=zaLV0-2WqEs",
    "Rating": 6.0,
    "MoviePrice": 90000,
    "Id": 10
  },
  {
    "MovieName": "Gifted",
    "ImagePath": "/images/giftedCover.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "6+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN TR",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Marc Webb",
    "MovieGenre": "Drama",
    "MovieActors": "Chris Evans Mckenna Grace Lindsay Duncan",
    "MovieDuration": "02:10:00",
    "Theater": None,
    "About": "Frank, a single man raising his child prodigy niece Mary, is drawn into a custody battle with his mother.",
    "MovieYear": 2017,
    "MovieLink": "https://www.youtube.com/watch?v=tI01wBXGHUs",
    "Rating": 7.6,
    "MoviePrice": 80000,
    "Id": 11
  },
  {
    "MovieName": "Kutsal Damacana 4",
    "ImagePath": "/images/kutsalCover.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "TR",
    "MovieCondition": "soon",
    "MovieCountry": "Turkey",
    "MovieDirector": "Kamil Çetin",
    "MovieGenre": "Comedy",
    "MovieActors": "Şafak Sezer Ersin Korkut Onur Böyüktopçu Müjde Uzman",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "It tells the story of Fikret, who accidentally becomes a priest. Fikret finds himself in an unpredictable position on the priesthood path he accidentally entered. Unexpectedly rising to the Vatican, Fikret now decides to return to his homeland.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=HphAPON03o8",
    "Rating": 3.0,
    "MoviePrice": 80000,
    "Id": 12
  },
  {
    "MovieName": "Passengers",
    "ImagePath": "/images/passengersCover.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN RU TR",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Morten Tyldum",
    "MovieGenre": "Science Fiction , Drama, Thriller, Adventure, Romance",
    "MovieActors": "Jennifer Lawrence Chris Pratt Michael Sheen Laurence Fishburne Andy García",
    "MovieDuration": "02:30:00",
    "Theater": None,
    "About": "A malfunction in a sleeping pod on a spacecraft traveling to a distant colony planet wakes one passenger 90 years early.",
    "MovieYear": 2016,
    "MovieLink": "https://www.youtube.com/watch?v=BJWR0io_SuE",
    "Rating": 7.0,
    "MoviePrice": 90000,
    "Id": 13
  },
  {
    "MovieName": "A Beautiful Mind",
    "ImagePath": "/images/abeautifulmindCover.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN TR",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Ron Howard",
    "MovieGenre": "Biography, Drama",
    "MovieActors": "Akiva Goldsman Sylvia Nasar",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "After John Nash, a brilliant but asocial mathematician, accepts secret work in cryptography, his life takes a turn for the nightmarish.",
    "MovieYear": 2001,
    "MovieLink": "https://www.youtube.com/watch?v=9wZM7CQY130",
    "Rating": 8.2,
    "MoviePrice": 90000,
    "Id": 14
  },
  {
    "MovieName": "Chernobyl",
    "ImagePath": "/images/chernobyl.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN RU TR",
    "MovieCondition": "today",
    "MovieCountry": "USA",
    "MovieDirector": "Craig Mazin",
    "MovieGenre": "Drama, History, Thriller",
    "MovieActors": "Jessie Buckley Jared Harris Stellan Skarsgård",
    "MovieDuration": "01:10:00",
    "Theater": None,
    "About": "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
    "MovieYear": 2019,
    "MovieLink": "https://www.youtube.com/watch?v=s9APLXM9Ei8",
    "Rating": 9.4,
    "MoviePrice": 80000,
    "Id": 15
  },
  {
    "MovieName": "Julia & Julie",
    "ImagePath": "/images/julia.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN TR",
    "MovieCondition": "soon",
    "MovieCountry": "USA",
    "MovieDirector": "Nora Ephron",
    "MovieGenre": "Biography, Drama, Romance",
    "MovieActors": "Amy Adams Meryl StreepChris Messina",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "Julia Child's story of her start in the cooking profession is intertwined with blogger Julie Powell's 2002 challenge to cook all the recipes in Child's first book.",
    "MovieYear": 2009,
    "MovieLink": "https://www.youtube.com/watch?v=ozRK7VXQl-k",
    "Rating": 7.0,
    "MoviePrice": 80000,
    "Id": 16
  },
  {
    "MovieName": "Bergen",
    "ImagePath": "/images/bergen.png",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "TR",
    "MovieCondition": "soon",
    "MovieCountry": "USA",
    "MovieDirector": "Caner Alper Mehmet Binay",
    "MovieGenre": "Biography, Drama, Music",
    "MovieActors": "Farah Zeynep Abdullah Erdal Besikçioglu Sebnem Sönmez",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "Bergen, a valuable turkish arabesque singer, fights to stay afloat despite all the difficulties in her life.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=dMsSORIgsOg",
    "Rating": 6.9,
    "MoviePrice": 90000,
    "Id": 17
  },
  {
    "MovieName": "Wonder",
    "ImagePath": "/images/wonder.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "6+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN TR",
    "MovieCondition": "soon",
    "MovieCountry": "USA",
    "MovieDirector": "Stephen Chbosky",
    "MovieGenre": "Drama, Family",
    "MovieActors": "Jacob Tremblay Owen Wilson Izabela Vidovic",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "Based on the New York Times bestseller, this movie tells the incredibly inspiring and heartwarming story of August Pullman, a boy with facial differences who enters the fifth grade, attending a mainstream elementary school for the first time.",
    "MovieYear": 2017,
    "MovieLink": "https://www.youtube.com/watch?v=Ob7fPOzbmzE",
    "Rating": 7.9,
    "MoviePrice": 90000,
    "Id": 18
  },
  {
    "MovieName": "The Fault In Our Stars",
    "ImagePath": "/images/thefault.jpg",
    "MovieDate": datetime.date.today().strftime("%d/%m/%Y"),
    "Age": "16+",
    "MovieFormat": "2D",
    "MovieLanguages": "EN TR",
    "MovieCondition": "soon",
    "MovieCountry": "USA",
    "MovieDirector": "Josh Boone",
    "MovieGenre": "Drama, Romance",
    "MovieActors": "Shailene Woodley Ansel ElgortNat Wolff",
    "MovieDuration": "01:40:00",
    "Theater": None,
    "About": "Two teenage cancer patients begin a life-affirming journey to visit a reclusive author in Amsterdam.",
    "MovieYear": 2023,
    "MovieLink": "https://www.youtube.com/watch?v=642lKXC97c4",
    "Rating": 7.7,
    "MoviePrice": 90000,
    "Id": 19
  }
]
user = [{
        'UserName':"Jack",
        'UserSurname':"Rose",
        'UserEmail':"user@gmail.com",
        'UserPassword':"SGVsbG8sIFdvcmxkIQ==",
        'Id':1
        }]


admin = [{
        'Email':"an@gmail.com",
        'Password':"MTIz",
        'Id':1
        }]


adminSelected = [{
    'Movie':
    {
        'MovieName':"Shazam! Fury of the Gods",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"2:00 PM",
        'Duration':"02:16:00",
        'Price':80000,
        'Theater':"Flicker Palace Ohio",
        'Id':5
    },
    'ButtonName':"threeten",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Shazam! Fury of the Gods",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"2:00 PM",
        'Duration':"02:16:00",
        'Price':80000,
        'Theater':"Flicker Palace Ohio",
        'Id':5
    },
    'ButtonName':"onefive",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Shazam! Fury of the Gods",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"2:00 PM",
        'Duration':"02:16:00",
        'Price':80000,
        'Theater':"Flicker Palace Ohio",
        'Id':5
    },
    'ButtonName':"onesix",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Julia & Julie",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"03:00:00",
        'Price':80000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':77
    },
    'ButtonName':"tenfourteen",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Julia & Julie",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"03:00:00",
        'Price':80000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':77
    },
    'ButtonName':"eightfourteen",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Julia & Julie",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"03:00:00",
        'Price':80000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':77
    },
    'ButtonName':"ninefourteen",
    'IsChecked':"true"
    },{
    'Movie':{
        'MovieName':"Julia & Julie",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"03:00:00",
        'Price':80000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':77
    },
    'ButtonName':"tenthirteen",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Julia & Julie",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"03:00:00",
        'Price':80000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':77
    },
    'ButtonName':"elevenfourteen",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Epic Tales",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",
        'Duration':"01:55:00",
        'Price':60000,
        'Theater':"Flicker Palace Ohio",
        'Id':20
    },
    'ButtonName':"sevenfourteen",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Epic Tales",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",
        'Duration':"01:55:00",
        'Price':60000,
        'Theater':"Flicker Palace Ohio",
        'Id':20
    },
    'ButtonName':"fivenine",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Epic Tales",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",
        'Duration':"01:55:00",
        'Price':60000,
        'Theater':"Flicker Palace Ohio",
        'Id':20
    },
    'ButtonName':"onetwo",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Epic Tales",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",
        'Duration':"01:55:00",
        'Price':60000,
        'Theater':"Flicker Palace Ohio",
        'Id':20
    },
    'ButtonName':"sixfive",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Epic Tales",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",
        'Duration':"01:55:00",
        'Price':60000,
        'Theater':"Flicker Palace Ohio",
        'Id':20
    },
    'ButtonName':"foureight",
    'IsChecked':"true"
    },{
    'Movie':
    {
        'MovieName':"Shazam! Fury of the Gods",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"02:16:00",
        'Price':80000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':1
    },
    'ButtonName':"oneseven",
    'IsChecked':"true"
    }]
schedule = [{
    'MovieName': "Shazam! Fury of the Gods",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:16:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 1
    },{
    'MovieName': "Shazam! Fury of the Gods",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:16:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 2
    },{
    'MovieName': "Shazam! Fury of the Gods",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:16:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 3
  },
  {
    'MovieName': "Shazam! Fury of the Gods",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:16:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 4
  },
  {
    'MovieName': "Shazam! Fury of the Gods",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "2:00 PM",
    'Duration': "02:16:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 5
  },
  {
    'MovieName': "Forever",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 6
  },
  {
    'MovieName': "Forever",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 7
  },
  {
    'MovieName': "Forever",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 8
  },
  {
    'MovieName': "Forever",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 9
  },
  {
    'MovieName': "The LockSmith",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:20:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 10
  },
  {
    'MovieName': "The LockSmith",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:20:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 11
  },
  {
    'MovieName': "The LockSmith",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:20:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 12
  },
  {
    'MovieName': "The LockSmith",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:20:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 13
  },
  {
    'MovieName': "The LockSmith",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "6:00 PM",
    'Duration': "02:20:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 14
  },
  {
    'MovieName': "The LockSmith",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:20:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 14
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 15
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace New York",
    'Id': 16
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace Ohio",
    'Id': 17
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 18
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace New York",
    'Id': 19
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace Ohio",
    'Id': 20
  },
  {
    'MovieName': "Epic Tales",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:55:00",
    'Price': 60000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 21
  },
  {
    'MovieName': "Scream 6",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 22
  },
  {
    'MovieName': "Scream 6",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 23
  },
  {
    'MovieName': "Scream 6",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 24
  },
  {
    'MovieName': "Scream 6",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 25
  },
  {
    'MovieName': "Scream 6",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 26
  },
  {
    'MovieName': "Scream 6",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 27
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 28
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 29
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 30
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 31
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 32
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 33
  },
  {
    'MovieName': "65",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:25:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 34
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 35
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 36
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 37
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 38
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 39
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "10:00 AM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 40
  },
  {
    'MovieName': "Cocaine Bear",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:40:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 41
  },
  {
    'MovieName': "Ant-Man and the Wasp: Quantumania",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:05:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 42
  },
  {
    'MovieName': "Ant-Man and the Wasp: Quantumania",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:16:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 43
  },
  {
    'MovieName': "Ant-Man and the Wasp: Quantumania",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:05:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 44
  },
  {
    'MovieName': "Ant-Man and the Wasp: Quantumania",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:05:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 45
  },
  {
    'MovieName': "Ant-Man and the Wasp: Quantumania",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:05:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 46
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 47
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 48
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 49
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 50
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 51
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 52
  },
  {
    'MovieName': "Prestij Meselesi",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 53
  },
  {
    'MovieName': "Gifted",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 54
  },
  {
    'MovieName': "Gifted",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 55
  },
  {
    'MovieName': "Gifted",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 56
  },
  {
    'MovieName': "Gifted",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 57
  },
  {
    'MovieName': "Kutsal Damacana 4",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "01:50:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 58
  },
  {
    'MovieName': "Kutsal Damacana 4",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:50:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 59
  },
  {
    'MovieName': "Kutsal Damacana 4",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "01:50:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 60
  },
  {
    'MovieName': "Kutsal Damacana 4",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "01:50:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 61
  },
  {
    'MovieName': "Passengers",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 62
  },
  {
    'MovieName': "Passengers",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 63
  },
  {
    'MovieName': "Passengers",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 64
  },
  {
    'MovieName': "Passengers",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 65
  },
  {
    'MovieName': "A Beautiful Mind",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "2:00 PM",
    'Duration': "03:10:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 66
  },
  {
    'MovieName': "A Beautiful Mind",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "03:10:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 67
  },
  {
    'MovieName': "A Beautiful Mind",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "1:00 PM",
    'Duration': "03:10:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 68
  },
  {
    'MovieName': "A Beautiful Mind",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "03:10:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 68
  },
  {
    'MovieName': "A Beautiful Mind",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "2:00 PM",
    'Duration': "03:10:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 70
  },
  {
    'MovieName': "Chernobyl",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "00:56:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 71
  },
  {
    'MovieName': "Chernobyl",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "00:56:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 72
  },
  {
    'MovieName': "Chernobyl",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "00:56:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 73
  },
  {
    'MovieName': "Julia & Julie",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "2:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 74
  },
  {
    'MovieName': "Julia & Julie",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace New York",
    'Id': 75
  },
  {
    'MovieName': "Julia & Julie",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace Ohio",
    'Id': 76
  },
  {
    'MovieName': "Julia & Julie",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "03:00:00",
    'Price': 80000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 77
  },
  {
    'MovieName': "Bergen",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "03:00:00",
    'Price': 90000,
    'Theater': "Park Bulvar",
    'Id': 78
  },
  {
    'MovieName': "Bergen",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "12:00 PM",
    'Duration': "03:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 79
  },
  {
    'MovieName': "Bergen",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "03:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 80
  },
  {
    'MovieName': "Bergen",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "03:00:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 81
  },
  {
    'MovieName': "Wonder",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 95
  },
  {
    'MovieName': "Wonder",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "12:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 82
  },
  {
    'MovieName': "Wonder",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=4)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 83
  },
  {
    'MovieName': "Wonder",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=1)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:50:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 84
  },
  {
    'MovieName': "The Fault In Our Stars",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=3)).strftime("%d/%m/%Y"),
    'MovieDateTime': "3:00 PM",
    'Duration': "02:45:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 85
  },
  {
    'MovieName': "The Fault In Our Stars",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=0)).strftime("%d/%m/%Y"),
    'MovieDateTime': "12:00 PM",
    'Duration': "02:45:00",
    'Price': 90000,
    'Theater': "Flicker Palace New York",
    'Id': 86
  },
  {
    'MovieName': "The Fault In Our Stars",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=5)).strftime("%d/%m/%Y"),
    'MovieDateTime': "7:00 PM",
    'Duration': "02:45:00",
    'Price': 90000,
    'Theater': "Flicker Palace Ohio",
    'Id': 87
  },
  {
    'MovieName': "The Fault In Our Stars",
    'MovieDate': (datetime.date.today() + datetime.timedelta(days=2)).strftime("%d/%m/%Y"),
    'MovieDateTime': "5:00 PM",
    'Duration': "02:45:00",
    'Price': 90000,
    'Theater': "Flicker Palace Las Vegas",
    'Id': 88
  }]
toggleButtonState = [{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"2:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Ohio",
            'Id':5
        },
    'ButtonName':"threeten",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"2:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Ohio",
            'Id':5
        },
    'ButtonName':"onefive",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"2:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Ohio",
            'Id':5
        },
    'ButtonName':"onesix",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Julia & Julie",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"03:00:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':77
        },
    'ButtonName':"tenfourteen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Julia & Julie",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"03:00:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':77
        },
    'ButtonName':"eightfourteen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Julia & Julie",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"03:00:00",
            'Price':80000,'Theater':"Flicker Palace Las Vegas",
            'Id':77
        },
    'ButtonVegasName':"ninefourteen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Julia & Julie",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"03:00:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':77
        },
    'ButtonName':"tenthirteen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Julia & Julie",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"03:00:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':77
        },
    'ButtonName':"elevenfourteen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"sevenfourteen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"fivenine",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"onetwo",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"sixfive",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"foureight",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':1
        },
    'ButtonName':"oneseven",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"The LockSmith",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"5:00 PM",
            'Duration':"02:20:00",
            'Price':90000,
            'Theater':"Flicker Palace New York",
            'Id':11
        },
    'ButtonName':"threesix",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"2:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Ohio",
            'Id':5
        },
    'ButtonName':"threefive",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"2:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Ohio",
            'Id':5
        },
    'ButtonName':"threesix",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Forever",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"02:00:00",
            'Price':90000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':6
        },
    'ButtonName':"sixsix",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Forever",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"02:00:00",
            'Price':90000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':6
        },
    'ButtonName':"eightseven",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Forever",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"02:00:00",
            'Price':90000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':6
        },
    'ButtonName':"seveneight",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Forever",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"02:00:00",
            'Price':90000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':6
        },
    'ButtonName':"seventen",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Forever",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"02:00:00",
            'Price':90000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':6
        },
    'ButtonName':"seveneleven",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':1
        },
    'ButtonName':"fivefive",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Shazam! Fury of the Gods",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"3:00 PM",
            'Duration':"02:16:00",
            'Price':80000,
            'Theater':"Flicker Palace Las Vegas",
            'Id':1
        },
    'ButtonName':"seveneight",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"ninethree",
    'IsChecked':"true"
    },{
    'Movie':
        {
            'MovieName':"Epic Tales",
            'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
            'MovieDateTime':"1:00 PM",
            'Duration':"01:55:00",
            'Price':60000,
            'Theater':"Flicker Palace Ohio",
            'Id':20
        },
    'ButtonName':"eightthree",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Epic Tales",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",'Duration':"01:55:00",
        'Price':60000,
        'Theater':"Flicker Palace Ohio",
        'Id':20
        },
    'ButtonName':"eightsix",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Forever",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"02:00:00",
        'Price':90000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':7},
    'ButtonName':"sevenseven",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Forever",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"02:00:00",
        'Price':90000,
        'Theater':"Flicker Palace Las Vegas",'Id':7
        },
    'ButtonName':"sixfive",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Forever",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"3:00 PM",
        'Duration':"02:00:00",
        'Price':90000,
        'Theater':"Flicker Palace Las Vegas",
        'Id':7
        },
    'ButtonName':"fivethree",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Kutsal Damacana 4",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"1:00 PM",
        'Duration':"01:50:00",
        'Price':80000,
        'Theater':"Flicker Palace Ohio",
        'Id':60
        },
    'ButtonName':"threesix",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Shazam! Fury of the Gods",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"2:00 PM",
        'Duration':"02:16:00",
        'Price':80000,
        'Theater':"Flicker Palace Ohio",
        'Id':5
        },
    'ButtonName':"threefive",
    'IsChecked':"true"
    },{
    'Movie':
        {
        'MovieName':"Gifted",
        'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),
        'MovieDateTime':"5:00 PM",
        'Duration':"03:00:00",'Price':80000,'Theater':"Flicker Palace Las Vegas",'Id':54},'ButtonName':"sixeight",'IsChecked':"true"},{'Movie':{'MovieName':"Gifted",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"5:00 PM",'Duration':"03:00:00",'Price':80000,'Theater':"Flicker Palace Las Vegas",'Id':54},'ButtonName':"sixseven",'IsChecked':"true"},{'Movie':{'MovieName':"The LockSmith",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:20:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':10},'ButtonName':"seveneleven",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace New York",'Id':8},'ButtonName':"sixfive",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace New York",'Id':8},'ButtonName':"fivethree",'IsChecked':"true"},{'Movie':{'MovieName':"Shazam! Fury of the Gods",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:16:00",'Price':80000,'Theater':"Flicker Palace Las Vegas",'Id':1},'ButtonName':"threesix",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"1:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':6},'ButtonName':"sixsix",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"1:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':6},'ButtonName':"seveneight",'IsChecked':"true"},{'Movie':{'MovieName':"Shazam! Fury of the Gods",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"2:00 PM",'Duration':"02:16:00",'Price':80000,'Theater':"Flicker Palace Ohio",'Id':5},'ButtonName':"threefive",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':7},'ButtonName':"fivethree",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':7},'ButtonName':"sixfive",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace New York",'Id':9},'ButtonName':"fivethree",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"1:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':6},'ButtonName':"fivefive",'IsChecked':"true"},{'Movie':{'MovieName':"The LockSmith",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"1:00 PM",'Duration':"02:20:00",'Price':90000,'Theater':"Flicker Palace Ohio",'Id':14},'ButtonName':"fivetwo",'IsChecked':"true"},{'Movie':{'MovieName':"Forever",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"3:00 PM",'Duration':"02:00:00",'Price':90000,'Theater':"Flicker Palace Las Vegas",'Id':7},'ButtonName':"fivethree",'IsChecked':"true"},{'Movie':{'MovieName':"Shazam! Fury of the Gods",'MovieDate':datetime.date.today().strftime("%d/%m/%Y"),'MovieDateTime':"2:00 PM",'Duration':"02:16:00",'Price':80000,'Theater':"Flicker Palace Ohio",'Id':5},'ButtonName':"threesix",'IsChecked':"true"}]

@app.route('/movies', methods=['GET', 'POST'])
def get_movies():
    return jsonify(movie)
@app.route('/register', methods=['POST'])
def register():
    global user

    name = request.json['UserName']
    surname = request.json['UserSurname']
    email = request.json['UserEmail']
    password = request.json['UserPassword']

    id = len(user)+1

    new_user = {
        "UserName": name,
        "UserSurname": surname,
        "UserEmail": email,
        "UserPassword": password,
        "Id":id
    }

    user.append(new_user)

    updated_user = json.dumps(user)

    return  updated_user
@app.route('/users', methods=['GET'])
def get_users():
    return jsonify(user)

@app.route('/admin', methods=['GET'])
def get_admin():
    return jsonify(admin)
@app.route('/addmovie', methods=['POST'])
def add_movies():
    global movie
    movie_name =request.json['MovieName']
    image_path = request.json['ImagePath']
    movie_date = request.json['MovieDate']
    age = request.json['Age']
    movie_format = request.json['MovieFormat']
    movie_condition = request.json['MovieCondition']
    movie_lang = request.json['MovieLanguages']
    movie_country = request.json['MovieCountry']
    movie_director = request.json['MovieDirector']
    movie_genre = request.json['MovieGenre']
    movie_actors = request.json['MovieActors']
    movie_duration = request.json['MovieDuration']
    about = request.json['About']
    year = request.json['MovieYear']
    link = request.json['MovieLink']
    rating = request.json['Rating']
    price = request.json['MoviePrice']
    id = len(movie)+2

    new_movie ={
    "MovieName": movie_name,
    "ImagePath": image_path,
    "MovieDate": movie_date,
    "Age": age,
    "MovieFormat": movie_format,
    "MovieLanguages": movie_lang,
    "MovieCondition": movie_condition,
    "MovieCountry": movie_country,
    "MovieDirector":  movie_director,
    "MovieGenre": movie_genre,
    "MovieActors":  movie_actors,
    "MovieDuration": movie_duration,
    "Theater": None,
    "About": about,
    "MovieYear":year,
    "MovieLink": link,
    "Rating":  rating,
    "MoviePrice": price,
    "Id": id
    }

    movie.append(new_movie)
    updated_movie = json.dumps(movie)
    return  updated_movie
@app.route('/toggleButtonState', methods=['GET'])
def get_toggleButtonState():
    return jsonify(toggleButtonState)
@app.route('/schedule', methods=['GET'])
def get_schedule():
    return jsonify(schedule)
@app.route('/adminSelected', methods=['GET'])
def get_adminSelected():
    return jsonify(adminSelected)
@app.route('/editmovie/<int:movie_id>', methods=['PUT'])
def edit_movie(movie_id):
    global movie
    updated_movie_data = request.get_json()

    for m in movie:
        if m['Id'] == movie_id:
            m.update(updated_movie_data)
            return jsonify({'message': 'Movie updated successfully'})

    return jsonify({'error': 'Movie not found'}), 404
@app.route('/deletemovie/<int:movie_id>', methods=['DELETE'])
def delete_movie(movie_id):
    global movie

    for m in movie:
        if m['Id'] == movie_id:
            movie.remove(m)
            return jsonify({'message': 'Movie deleted successfully'})

    return jsonify({'error': 'Movie not found'}), 404
@app.route('/addtogglebutton', methods=['POST'])
def add_toggleButtonState():
    movie_data = request.get_json()

    movie_name = movie_data['Movie']['MovieName']
    movie_date = movie_data['Movie']['MovieDate']
    movie_datetime = movie_data['Movie']['MovieDateTime']
    duration = movie_data['Movie']['Duration']
    price = movie_data['Movie']['Price']
    theater = movie_data['Movie']['Theater']
    movie_id = movie_data['Movie']['Id']
    button_name = movie_data['ButtonName']
    is_checked = movie_data['IsChecked']

    new_togglebutton ={
    'Movie':
        {
        'MovieName':movie_name,
        'MovieDate':movie_date,
        'MovieDateTime':movie_datetime,
        'Duration':duration,
        'Price':price,
        'Theater':theater,
        'Id':movie_id,
        },
    'ButtonName':button_name,
    'IsChecked':is_checked
    }
    toggleButtonState.append(new_togglebutton)
    updated_togglebutton = json.dumps(toggleButtonState)
    return  updated_togglebutton
@app.route('/addadminselected', methods=['POST'])
def add_adminselected():
    movie_data = request.get_json()

    movie_name = movie_data['Movie']['MovieName']
    movie_date = movie_data['Movie']['MovieDate']
    movie_datetime = movie_data['Movie']['MovieDateTime']
    duration = movie_data['Movie']['Duration']
    price = movie_data['Movie']['Price']
    theater = movie_data['Movie']['Theater']
    movie_id = movie_data['Movie']['Id']
    button_name = movie_data['ButtonName']
    is_checked = movie_data['IsChecked']

    new_adminselected ={
    'Movie':
        {
        'MovieName':movie_name,
        'MovieDate':movie_date,
        'MovieDateTime':movie_datetime,
        'Duration':duration,
        'Price':price,
        'Theater':theater,
        'Id':movie_id,
        },
    'ButtonName':button_name,
    'IsChecked':is_checked
    }
    adminSelected.append(new_adminselected)
    updated_adminselected = json.dumps(adminSelected)
    return  updated_adminselected