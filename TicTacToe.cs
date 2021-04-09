using System;

class Game

{
	public char[] index =  {'1','2','3','4','5','6','7','8','9'};
	public char yourTurn,opponentsTurn;
	public int win;
	
	public void printGame ()
	{
		Console.WriteLine("\t\t      Tic Tac Toe \t\t\t");
		Console.WriteLine("Player 1 <-> X |---| Player 2 <-> O");
		Console.WriteLine("______________");
		for (int i = 0; i < 13 ; i++)
		{
			if ( i < 9)
			{
				Console.Write("|  " + index[i]);
			}
			if ( i == 2 || i == 5 || i == 10)
			{
				Console.WriteLine(" |");
			}
			if ( i == 12 )
			{
				Console.WriteLine("|_______________\n");
			}
		}
	}

	public void positionOfElements (char choice, char position)
	{
		if (index[0] == position)
		{
			index[0] = choice;
		}
		else if (index[1] == position)
		{
			index[1] = choice;
		}
		else if (index[2] == position)
		{
			index[2] = choice;
		}
		else if (index[3] == position)
		{
			index[3] = choice;
		}
		else if (index[4] == position)
		{
			index[4] = choice;
		}
		else if (index[5] == position)
		{
			index[5] = choice;
		}
		else if (index[6] == position)
		{
			index[6] = choice;
		}
		else if (index[7] == position)
		{
			index[7] = choice;
		}
		else if (index[8] == position)
		{
			index[8] = choice;
		}
	}

	public void gameWinner ()
	{
		if ((index[0] == index[1] && index[1] == index[2]) ||
		    (index[3] == index[4] && index[4] == index[5]) || //Horizontal win
			(index[6] == index[7] && index[7] == index[8]) ||
			(index[0] == index[3] && index[3] == index[6]) ||
			(index[1] == index[4] && index[4] == index[7]) || //Vertical win
			(index[2] == index[5] && index[5] == index[8]) ||
			(index[0] == index[4] && index[4] == index[8]) || //Diagonal win
			(index[2] == index[4] && index[4] == index[6]) )
		{
			win = 1;
		}
		if (win == 1)
		{
			int numberOfX = 0;
			int numberOfO = 0;
			for (int i = 0; i < 9; i++)
			{
				if ( index[i] == 'X' )
				{
					numberOfX++;
				}
				else if ( index[i] == 'O' )
				{
					numberOfO++;			
				}
			}
			if (numberOfX > numberOfO && numberOfX != 5)
			{
				Console.WriteLine("Player 1 has won!");
			}
			else if (numberOfX == numberOfO)
			{
				Console.WriteLine("Player 2 has won!");
			}
		else
		{
			Console.WriteLine("It's a draw!");
		}
			
		}			
	}

	public void gameTurns (char choice)
	{
		if (choice == '1')
		{
			yourTurn = 'X';
			opponentsTurn = 'O';
		}
		else
		{
			yourTurn = 'O';
			opponentsTurn = 'X';
		}
	}
	
	public void newGame ()
	{
		char choice = Convert.ToChar(Console.ReadLine());
		gameTurns(choice);
		Console.WriteLine("The game has begun!");
		for (int i=1; i<10; i++)
		{
			Console.WriteLine("Pick your position.");
			char position = Convert.ToChar(Console.ReadLine());
			if (choice == '1')
			{
				if (i % 2 != 0)
				{
					positionOfElements(yourTurn,position);
				}
				else
				{
					positionOfElements(opponentsTurn,position);
				}
			}
			else if (choice == '2')
			{
				if (i % 2 != 0)
				{
					positionOfElements(opponentsTurn,position);
				}
				else
				{
					positionOfElements(yourTurn,position);
				}
			}		
			Console.Clear();
			printGame();
			gameWinner();
			if (win == 1)
			{
				break;
			}
		}
	}
}

public class Program
{
	public static void Main()
	{
		Game TicTacToe = new Game();
		TicTacToe.printGame();
		Console.WriteLine("Pick your turn: \n1. X \n2. O ");
		TicTacToe.newGame();
	}
}