# A program that randomly generates directions for airport lines.

.data
    .align 2
    prompt: .asciiz "Enter a number to generate a random number. Enter 0 to quit."
    go_left: .asciiz "Go left"
    go_right: .asciiz "Go right"
    newline: .asciiz "\n"

    .macro end
        li $v0, 10
        syscall
    .end_macro

    .macro print_newline
        li $v0, 4
        la $a0, newline
        syscall
    .end_macro

    .eqv CONST_END, 10
    .eqv CONST_STR, 4
    .eqv CONST_INT_IN, 5
.text
    main:
        li $v0, CONST_STR
        la $a0, prompt
        syscall

        # Wait for enter key
        li $v0, CONST_INT_IN
        syscall

        # Check input
        beqz $v0, quit # Checks if input is not empty

        jal generate_rand

        # Random value in $v0
        beqz $v0, print_left
        beq $v0, 1, print_right

        j quit


    generate_rand:
        # Generate a random number [0, 2)
        li $v0, 42
        li $a1, 2 # Upper bound
        syscall # Random number gets stored in $a0

        move $v0, $a0

        jr $ra

    print_left:
        li $v0, CONST_STR
        la $a0, go_left
        syscall

        print_newline()

        j main

    print_right:
        li $v0, CONST_STR
        la $a0, go_right
        syscall

        print_newline()

        j main

    quit:
        end()