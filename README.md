# SlotMachine


<h1>An API for a Slotmachine.</h1>

<p>Request must be made with a <b>POST</b> and on the JSON format as follows.</p>

{ "bet": number  }


Where {X} must be substitute by a number greater than 0.
Example:
{"bet": 10}


the program will follow this table

<table border="1">
<thead>
<th>Symbol</th> <th>Value</th>  <th>Weight</th>
</thead>
<tbody>
<tr>
<td>"A"</td>  <td>100</td>     <td>1</td>
</tr>
<tr>
<td>"B"</td>  <td>50</td>     <td>2</td>
</tr>
<tr>
<td>"C"</td>  <td>25</td>     <td>4</td>
</tr>
<tr>
<td>"D"</td>  <td>20</td>     <td>8</td>
</tr>
<tr>
<td>"E"</td>  <td>15</td>     <td>12</td>
</tr>
<tr>
<td>"F"</td>  <td>10</td>     <td>16</td>
</tr>
<tr>
<td>"G"</td>  <td>5</td>     <td>20</td>
</tr>
<tr>
<td>"H"</td>  <td>1</td>     <td>24</td>
</tr>
</tbody>
</table>

<p>Where <b>Symbol</b>, is the symbol it will generate, <b>Value</b> is the bet multiplier, and <b>Weight</b> is the rarity of it, going from 1 as the rarest, and 24 the more commun.</p>

The program returns 3 Symbols, and will only multiply the bet if the symbols are the same.
{ "symbols": string[], "won": number }

For example:
{ "symbols": ["B","B","B"], "won": 50 }

(if the request bet is equals to 1)
