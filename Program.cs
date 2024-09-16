//See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// START MAIN

string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium); 
DisplayStadiumDetails(stadium, game);
// END MAIN



static string  GetEnjoymentLevel(){
    string enjoymentLevel = "";
    System.Console.WriteLine("How fun do you want it?");
    enjoymentLevel = Console.ReadLine();
    
    return enjoymentLevel;
  
}  

  

static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "Boring"){
        return "Neyland Stadium";
    }
    else if(enjoymentLevel == "Average"){  
        return "Jordan-Hare Stadium";
    }
     else if(enjoymentLevel == "Fun"){  
        return "Tiger Stadium";
     }
     else if (enjoymentLevel == "Epic"){
        return "Saban Field at Bryant-Denny Stadium";
     }
     else return "no stadium";
     

}

static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium"){
        return "Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){  
        return "Kentucky";
    }
    else if(stadium == "Tiger Stadium"){    
        return "Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadium"){
        return "Auburn";
    }
    else return "no game ";
}
 
static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine(stadium + " vs " + game);
}





