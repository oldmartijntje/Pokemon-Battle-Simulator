public class NameGenerator
{

    public static List<string> names = new List<string>
    {
        "Chuck Norris",
        "Rick Astley",
        "Doge",
        "Grumpy Cat",
        "SpongeBob SquarePants",
        "Harambe",
        "Bad Luck Brian",
        "Success Kid",
        "Distracted Boyfriend",
        "Hide the Pain Harold",
        "Jumpman McPlumber",
        "Princess Peachy Keen",
        "Bowser the Koopa Troopa",
        "Luigi the Green Machine",
        "Toadstool Troublemaker",
        "Link the Clueless Hero",
        "Kirby the Hungry Fluffball",
        "Donkey Kong the Banana Bandit",
        "Samus Aran the Space Bounty Hunter",
        "Pikachu the Electric Mouse",
        "All Might the Buffoon",
        "Deku the Quirkless Wonder",
        "Bakugo the Explosive Hotshot",
        "Uravity the Zero-Gravity Heroine",
        "Froppy the Froggy Hero",
        "Irony Man",
        "Captain Amusing",
        "Hulk Smash Puns",
        "Thor the Thunderous Jokester",
        "Black Widow the Sneaky Prankster",
        "Code Ninja",
        "Byte Me",
        "Stack Overflow Lover",
        "Variable Vixen",
        "Bug Slayer"
    };

    public static string GetRandomName()
    {
        Random random = new Random();
        int randomIndex = random.Next(names.Count);
        return names[randomIndex];
    }

}