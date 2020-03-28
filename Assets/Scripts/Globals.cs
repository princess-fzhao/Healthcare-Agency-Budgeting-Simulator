﻿using System.Collections;
using System.Collections.Generic;

static class Globals {
	public static float volume = 1.0f;
	public static int difficulty = 1;				// 0,1,2 = easy,normal,hard?
	public static int original_budget = 7178;		// Starting budget of quarter 1
	public static int starting_budget;				// Maximum amount that can be spent this quarter
	public static Dictionary<string,int> budget = new Dictionary<string, int>();	// Allocated budget for each item
	public static int quarter = 1;				// Current quarter number

	public static int Operations() {
		return budget["Media Monitoring"] + budget["Health and Safety Inspections"] + budget["Outbreak Response Team"];
	}

	public static int Research() {
		return 0;
	}

	public static int InternationalHealth() {
		return 0;
	}

	public static int Miscellaneous() {
		return 0;
	}

	public static int Region(int i) {
		return 0;
	}

	public static int Total() {
		int total = 0;
		for (int i = 0; i < 5; i++)
			total += Region(i);
		return total + Operations() + Research() + InternationalHealth() + Miscellaneous();
	}
}
