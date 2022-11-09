# SlotMachine


An API for a Slotmachine.

Request must be made with a POST and on the JSON format as follows.

{ "bet": number  }


Where {X} must be substitute by a number greater than 0.
Example:
{"bet": 10}


the program will follow this table
--------------------------------
Symbol      Value     Weight
"A"         100          1
"B"         50           2
"C"         25           4
"D"         20           8
"E"         15          12
"F"         10          16
"G"         5           20
"H"         1           24
--------------------------------

Where Symbol, is the symbol it will generate, Value is the bet multiplier, and Weight is the rarity of it, going from 1 as the rarest, and 24 the more commun.

The program returns 3 Symbols, and will only multiply the bet if the symbols are the same.
{ "symbols": string[], "won": number }

For example:
{ "symbols": ["B","B","B"], "won": 50 }

(if the request bet is equals to 1)
