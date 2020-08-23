section .data
    msg db "Hello world!",10      ; 10 is the ASCII code for a new line (LF)
    len     equ $ - msg     ;msg length
    msg2 db "Hello wsssssssssssssorld!",10      ; 10 is the ASCII code for a new line (LF)
    len2     equ $ - msg2     ;msg length

section .text
  
  
    global _start
print:
    mov rax, 1
    mov rdi, 1
    ;mov rsi, msg
    ;mov rdx, len2
    syscall
    ret

_start:
    mov rsi, db "SS",10
    mov rdx, 3
    call print
    mov rax, 60
    mov rdi, 0
    syscall

