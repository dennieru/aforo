# aforo project



<code>
#OE    #
				CalculoAforo(area, [numeroPersonas]) 
				BEGIN
2		1			aforo := area / 3.46;
2		2			aforoActividad := area / actividad;
1		3			countAforo := 1;
1		4			countAforoActividad := 0;
1		5			delta := 0.01;

2		6			FOR i := 0 TO numeroPersonas DO
3		7				IF ((area/numero - 3.46) < delta) THEN
2		8					countAforo++;
3		9				ELSE IF ((area / numero - actividad) < delta)
2		10					countAforoActividad++;
		11				END IF
		12			END FOR

1		13			IF (countAforoActividad < countAforo) THEN
1		14				RETURN aforo;
1		15			ELSE RETURN aforoActividad;
		16			END IF
		17		END


</code>



