#include <stdio.h>
#include <stdlib.h>
#include <sys/time.h>
#include <assert.h>
#include "common.h"
//Genellikle birden fazla kaynak arasýnda paylaþým yapmasýný saðlayan kütüphane.

int main(int argc, char *argv[]){
    //argc represents the count of command-line arguments.
    //argv[] is array of string which represents the actual command-line arguments.
    
    if(argc !=2){
        fprintf(stderr,"usage: cpu <string>\n");
        exit(1);
    }
    char *str = argv[1];
    while (1)
    {
        Spin(1);
        printf("%s\n",str);
        /* code */
    }
    return 0;
    
}
