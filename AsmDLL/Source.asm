;  Projekt z Jêzyków assemblerowych - Algorytm KMP
;  Autor: Tomasz Halemba
;  Semestr: 5
;  Sekcja: 8
;  Rok akademicki: 2017/2018


.data
FORA	DQ	0					;variable for for
SYMBOL	DB	0					;variable to keep symbol
BEGINNING DQ 0					;beginning for shift table
BEGINNINGRDX DQ 0				;beginning for pattern table
BEGINNINGTEXT DQ 0				;beginning for text table


.CODE


; function to calculate shift table
;
;parameters:
;
; rcx - shift table and text size in 0 index of table
; rdx - pattern
; r8  - pattern size
; r10 - as "B" variable in for
; r11 - as "A" variable in for

;BEGINNING 		beginning for shift table
;BEGINNINGRDX 	beginning for pattern table

init_shift_asm PROC
		mov FORA,0
		mov r10,-1				;set r10 as "B" variable in for
		mov r11,0				;set r11 as "A" variable in for
		mov BEGINNING,rcx		;copy adres of beginning of shift table
		mov BEGINNINGRDX,rdx	;copy adres of beginning of pattern table
		mov eax,-1				;move -1 to rax
		mov [rcx], eax			;shift[0]=rax
		dec r8					;decrement size of pattern
		cmp r8,0				;check if r8 reach 0
		jle ending				;jump to ending if its less or equal
		jmp WHILE_LOOP			;jump to while loop


FOR_LOOP:
		inc r11					;r11++
		inc	r10					;r10++
		mov rax,4				;move 4 to rax
		imul r11				;multiply 4 by r11 rax=4*r11
		add rcx,rax				;add rax to shift table so its now have shift[r11(A)]
		mov rax,r10				;move r10 (B) to rax
		mov [rcx],rax			;shift[r11]=r10
		mov rcx,BEGINNING		;return to beginning of shift table
		dec r8					;r8--
		cmp r8,0				;compare r8 to 0
		jle ending				;jump to ending if its less or equal 

WHILE_LOOP:		
		mov rdx,BEGINNINGRDX	;move pattern table to beggining
		mov rax,r10				;move r10 (B) to rax
		cmp rax,0				;compare rax to 0
		jl FOR_LOOP				;jump if rax is less

		mov rax,r11				;mov rax to r11
		add rdx,rax				;add rax to table pattern
		mov rax,[rdx]			;rax=text[r11]
		mov SYMBOL,al			;take al(char) to the SYMBOL variable

		mov rdx,BEGINNINGRDX	;move pattern table to beggining

		mov rax,r10				;move r10 (B) to rax
		add rdx,rax				;add rax to table pattern
		mov rax,[rdx]			;rax=text[r10]

		cmp SYMBOL,al			;compare symbol variable to al
		je FOR_LOOP				;jump if symbols are equal

		mov rax,4				;move 4 to rax
		imul r10				;multiply 4 by r10 rax=4*r10
		add rcx,rax				;add rax to shift table so its now have shift[r10(B)]
		mov rax,[rcx]			;rax=text[r10]

		cmp rax,512				;compare it to big number (shift table have some big number instead of -1 for some reason)
		jg ZERO					;jump if its greater
		jmp NEXT				;jump to NEXT label
		ZERO:
		mov RAX,-1				;rax=-1
		NEXT:

		mov r10,rax				;r10(B)=rax
		mov rcx,BEGINNING		;return to beginning of shift table
		jmp WHILE_LOOP			;jump to WHILE_LOOP label

ending:		
		ret						;return to program
init_shift_asm endp




;function to find pattern in text using KMP algorythm
;
;parameters:
;
;rcx-shift table
;rdx-pattern 
;r8-pattern size
;r9-text
;r10 - "B" variable in for
;r11 - text size
;FORA -"A" variable in for

;BEGINNING 		beginning for shift table
;BEGINNINGRDX 	beginning for pattern table
;BEGINNINGTEXT  beginning for text table

kmp_asm PROC


		mov r11,[rcx]			;move text size to r11
		mov eax,-1
		mov [rcx],eax
		mov r10,0				;set r10 as "B" variable in for
		mov FORA,0				;set FORA as "A" variable in for

		mov BEGINNING,rcx		;copy adres of beginning of shift table
		mov BEGINNINGRDX,rdx	;copy adres of beginning of pattern table
		mov BEGINNINGTEXT,r9	;copy adres of beginning of text table
		cmp r11,0				;check if text size is 0
		jle ending				;jump to ending if its less or equal
		cmp r8,r10				;compare pattern size and r10(B)
		jle ending				;jump to ending if its less or equal
		jmp WHILE_LOOP			;jump to WHILE_LOOP Label


FOR_LOOP:
		inc FORA				;FORA++
		inc	r10					;r10++
		dec r11					;r11--
		cmp r11,0				;compare r11(text size) to 0
		jle ending				;jump to ending if its less or equal
		cmp r8,r10				;compare pattern size and r10(B)
		jle ending				;jump to ending if its less or equal


WHILE_LOOP:
		cmp r10,0				;compare r10(B) to 0
		jl FOR_LOOP				;jump if  r10 is smaler than 0	
		add r9,FORA				;add FORA to r9 
		mov rax,[r9]			;rax=text[FORA]
		mov SYMBOL,al

		mov r9,BEGINNINGTEXT	;return to beginning of text table
		mov rdx,BEGINNINGRDX	;return to beginning of pattern table
		add rdx,r10				;add r10 to pattern table so its now have pattern[r10(B)]
		mov rax,[rdx]			;rax=pattern[r10]

		cmp SYMBOL,al			;compare symbol variable to al
		je FOR_LOOP				;jump if symbols are equal

		mov rax,4				;move 4 to rax
		imul r10				;multiply 4 by r10 rax=4*r10
		add rcx,rax				;add rax to shift table so its now have shift[r10(B)]
		mov rax,[rcx]			;rax=text[r10]


		cmp rax,512				;compare it to big number (shift table have some big number instead of -1 for some reason)
		jg ZERO					;jump if its greater
		jmp NEXT				;jump to NEXT label
		ZERO:
		mov RAX,-1				;rax=-1

		NEXT:
		mov r10,rax				;r10(B)=rax
		mov rcx,BEGINNING		;return to beginning of shift table
		jmp WHILE_LOOP			;jump to WHILE_LOOP label

ending:	
		cmp r10,r8				;compare pattern size and r10(B)
		je NO_MATCH							
		mov rax,-1				;rax=0
		ret						;return to program

NO_MATCH:
		mov rax,FORA			;rax=1
		ret						;return to program
kmp_asm  endp
END