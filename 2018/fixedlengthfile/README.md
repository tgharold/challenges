# Fixed-length file processing

https://www.reddit.com/r/dailyprogrammer/comments/7b5u96/20171106_challenge_339_easy_fixedlength_file/

## Description

> Q: What if CSV files sucked and made no sense? 
>
> A: We would call them fixed-length files.

The TSYS Draft 256 fixed-length data exchange format is a good example of an industry standard, enterprise-grade dumpster fire.

## Basic

### Input file

```
Boyce Calles        83460319
::EXT::SAL 00000000000044722
Marcelo Candela     29040821
::EXT::JOB loser            
::EXT::SAL 00000000000047706
Milton Camper       32541106
```

### Expected result

`Marcelo Candela, $47,706`

## Challenge

### Input file

```
Boyce Calles        83460319
::EXT::SAL 00000000000044722
Marcelo Candela     29040821
::EXT::JOB loser            
::EXT::SAL 00000000000047706
Milton Camper       32541106
Luther Steffen      44311219
::EXT::SAL 00000000000047181
Quentin Salter      38590726
::EXT::JOB COW              
::EXT::SAL 00000000001859623
::EXT::COL humperdink       
Willian Chand       39560505
Major Bills         37790227
::EXT::SAL 00000000003561927
::EXT::JOB CFP              
::EXT::COL akkawi           
Benedict Ringel     95241209
Eddie Che           15830111
::EXT::SAL 00000000000046961
Drew Tynan          84260213
Bud Sloat           45371201
::EXT::JOB CTO              
::EXT::SAL 00000000004301076
::EXT::COL humperdink       
Allen Reade         46761110
Denny Cassidy       99710227
Arnulfo Herrada     84650626
::EXT::SAL 00000000000014737
::EXT::JOB mook             
Buck Goulette       84420413
::EXT::SAL 00000000000027329
Basil Tatum         97330503
::EXT::JOB loser            
Randy Ciulla        32031111
::EXT::SAL 00000000004669876
::EXT::JOB CHP              
::EXT::COL hummus           
Felipe Bungard      36500317
::EXT::SAL 00000000000049176
Irvin Plum          34491126
::EXT::JOB CEO              
::EXT::SAL 00000000002710511
::EXT::COL hummus           
Mel Quintanilla     73660811
::EXT::JOB CXO              
::EXT::SAL 00000000002184725
::EXT::COL akkawi           
Macie Tellez        31340718
::EXT::JOB CRO              
::EXT::SAL 00000000002503183
::EXT::COL hummus           
Wendi Brouse        53061118
::EXT::COL pickle           
::EXT::SAL 00000000003917526
::EXT::JOB CFO              
Synthia Simonds     76860807
::EXT::SAL 00000000001817483
::EXT::JOB COO              
::EXT::COL apple            
Gilma Spero         63180726
::EXT::SAL 00000000004180552
::EXT::JOB CIO              
::EXT::COL chartreuse       
Veronique Walters   60470224
Azalee Countryman   69460609
::EXT::JOB CZO              
::EXT::COL naranja          
::EXT::SAL 00000000002782843
Beata Ryans         18460107
::EXT::SAL 00000000000033073
Mercedez Mahon      26380323
Myrta Hine          81591009
Shanti Chan         19240722
::EXT::JOB mook             
::EXT::SAL 00000000000036496
Reta Eberly         55050821
::EXT::JOB loser            
::EXT::SAL 00000000000042240
Mirtha Mckissick    46730112
::EXT::JOB loser            
Marine Benn         10451207
Melanie Griffeth    59720804
::EXT::JOB mook             
Vanesa Plowman      28600505
::EXT::SAL 00000000000019935
Mamie Burchett      49870101
::EXT::JOB mook             
Aida Horton         65400523
::EXT::SAL 00000000000039958
::EXT::JOB peon             
Leia Principe       83050710
::EXT::SAL 00000000000023830
::EXT::JOB mook             
Olive Shield        70300120
::EXT::JOB loser            
::EXT::SAL 00000000000034563
Ellamae Galeana     46400508
::EXT::SAL 00000000000049203
```

### Expected result

```
Randy Ciulla, $4,669,876
```