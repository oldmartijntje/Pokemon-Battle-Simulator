public class Battle
{
    private List<Trainer> Trainers;
    private int CurrentRound;
    private int AmountOfRounds;
    private List<int> Scores;
    public Battle(int roundsToPlay, Trainer trainer1, Trainer trainer2)
    {
        this.CurrentRound = 0;
        this.Trainers = new List<Trainer>();
        this.Trainers.Add(trainer1);
        this.Trainers.Add(trainer2);
        this.AmountOfRounds = roundsToPlay;
        this.Scores = new List<int>();
        this.Scores.Add(0);
        this.Scores.Add(0);
    }

    private bool PlayFullRound()
    {
        this.CurrentRound++;
        Console.WriteLine("\n--------\nRound "+ this.CurrentRound + "!\n--------\n");
        
        Random random = new Random();

        if (this.Trainers[0].GetActivePokemonBeltId() == null)
        {
            int randomNumber = random.Next(0, 6);
            this.Trainers[0].SelectPokemonFromBelt(randomNumber);
        }
        if (this.Trainers[1].GetActivePokemonBeltId() == null)
        {
            int randomNumber = random.Next(0, 6);
            this.Trainers[1].SelectPokemonFromBelt(randomNumber);
        }
        int winner = this.checkRoundWinner();
        if ( winner == -1)
        {
            this.Trainers[0].PutPokemonBackInBall();
            this.Trainers[1].PutPokemonBackInBall();
            Console.WriteLine("\n--------\nIt's a Tie!\n--------\n");
        } else if (winner == 0)
        {
            this.Trainers[1].PutPokemonBackInBall();
            this.Scores[0]++;
            Console.WriteLine("\n--------\n"+ this.Trainers[winner].GetName() +" has won this round!\n--------\n");
        }
        else if (winner == 1)
        {
            this.Trainers[0].PutPokemonBackInBall();
            this.Scores[1]++;
            Console.WriteLine("\n--------\n" + this.Trainers[winner].GetName() + " has won this round!\n--------\n");
        }
        if (this.CurrentRound >= this.AmountOfRounds)
        {
            return true;
        } else
        {
            return false;
        }


    }

    private int checkRoundWinner()
    {
        if (this.Trainers[0].GetActivePokemon().GetType() == this.Trainers[1].GetActivePokemon().GetType())
        {
            Console.WriteLine("\n"+this.Trainers[0].GetActivePokemon().GetNickname() + " and " + this.Trainers[1].GetActivePokemon().GetNickname() + " are holding an endless staring contest.\nLet's just get this over with, it's a draw!\n");
            return -1;
        } else if (this.Trainers[0].GetActivePokemon().GetType() == this.Trainers[1].GetActivePokemon().GetWeakness())
        {
            Console.WriteLine("\n" + this.Trainers[0].GetActivePokemon().GetNickname() + " bodyslammed " + this.Trainers[1].GetActivePokemon().GetNickname() + ".\n" + this.Trainers[1].GetActivePokemon().GetNickname() + " is KO!\n");
            Console.WriteLine(this.Trainers[0].GetActivePokemon().GetNickname() + " has won this round!\n");
            return 0;
        } else
        {
            Console.WriteLine("\n" + this.Trainers[1].GetActivePokemon().GetNickname() + " tickles " + this.Trainers[0].GetActivePokemon().GetNickname() + ".\n" + this.Trainers[0].GetActivePokemon().GetNickname() + " is parylized and not able to fight.\n");
            Console.WriteLine(this.Trainers[1].GetActivePokemon().GetNickname() + " has won this round!\n");
            return 1;
        }
    }

    public int PlayFullGame()
    {
        this.CurrentRound = 0;
        while (true)
        {
            bool completedRounds = this.PlayFullRound();
            if (completedRounds)
            {
                break;
            }
        }
        Console.WriteLine("\n--------\nAnd the winner of this battle is......");
        int winner = this.GetWinner();
        if (winner == -1)
        {
            Console.WriteLine("Nobody!!! Cause it's a tie!!!\nThey both won "+ this.Scores[0]+" times.\n--------\n");
        } else
        {
            Console.WriteLine(this.Trainers[winner].GetName() + "!!!\n"+this.Trainers[winner].GetName() + " has won with "+this.Scores[winner]+" wins.\n--------\n");
        }
        return winner;
    }

    public int GetWinner()
    {
        if (this.Scores[0] > this.Scores[1])
        {
            return 0;
        } else if (this.Scores[0] > this.Scores[1])
        {
            return 1;
        } else
        {
            return -1;
        }
    }


}