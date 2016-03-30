	ORG C 2		%Origin of code segment
	LDA A		%Load operand from location A
	ADD B		%Add operand from location B
	STA S		%Store sum in location S
	HLT		%Halt computer
	ORG D 0		%Origin of data segment
A,	DEC 6		%Decimal operand
B,	HEX 4		%Hexadecimal operand
S,	DEC 0		%Sum stored in location S
	END		%End of symbolic program