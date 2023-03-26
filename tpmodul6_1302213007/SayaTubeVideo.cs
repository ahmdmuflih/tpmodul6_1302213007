﻿using System;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo (string title)
	{
		Random rand = new Random();
		this.id = rand.Next(10000, 99999);
		this.title = title;
		this.playCount = 0;
	}

	public void IncreasePlayCount (int count)
	{
		this.playCount += count;
	}

	public void PrintVideoDetails ()
	{
		Console.WriteLine("Video ID : {0} ", this.id);
		Console.WriteLine("Title : {0} ", this.title);
		Console.WriteLine("Play Count : {0} ", this.playCount);
	}
}