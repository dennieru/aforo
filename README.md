# aforo project

<table style="width:100%;border:none">
	<tr><th>#OE</th>    <th>#</th><th></th></tr>
	<tr><td></td><td></td><td><code>CalculoAforo(area, [numeroPersonas]) </code></td></tr>
	<tr><td></td><td></td><td><code>BEGIN</code></td></tr>
	<tr><td>2</td><td>1</td><td><code>	aforo := area / 3.46;</code></td></tr>
	<tr><td>2</td><td>2</td><td><code>	aforoActividad := area / actividad;</code></td></tr>
	<tr><td>1</td><td>3</td><td><code>	countAforo := 1;</code></td></tr>
	<tr><td>1</td><td>4</td><td><code>	countAforoActividad := 0;</code></td></tr>
	<tr><td>1</td><td>5</td><td><code>	delta := 0.01;</code></td></tr>
	<tr><td></td><td></td><td><code></code></td></tr>
	<tr><td>2</td><td>6</td><td><code>	FOR i := 0 TO numeroPersonas DO</code></td></tr>
	<tr><td>3</td><td>7</td><td><code>		IF ((area/numero - 3.46) < delta) THEN</code></td></tr>
	<tr><td>2</td><td>8</td><td><code>			countAforo++;</code></td></tr>
	<tr><td>3</td><td>9</td><td><code>		ELSE IF ((area / numero - actividad) < delta)</code></td></tr>
	<tr><td>2</td><td>10</td><td><code>			countAforoActividad++;</code></td></tr>
	<tr><td></td><td>11</td><td><code>		END IF</code></td></tr>
	<tr><td></td><td>12</td><td><code>	END FOR</code></td></tr>
	<tr><td></td><td></td><td><code></code></td></tr>
	<tr><td>1</td><td>13</td><td><code>	IF (countAforoActividad < countAforo) THEN</code></td></tr>
	<tr><td>1</td><td>14</td><td><code>		RETURN aforo;</code></td></tr>
	<tr><td>1</td><td>15</td><td><code>	ELSE RETURN aforoActividad;</code></td></tr>
	<tr><td></td><td>16</td><td><code>	END IF</code></td></tr>
	<tr><td></td><td>17</td><td><code>END</code></td></tr>
</table>



