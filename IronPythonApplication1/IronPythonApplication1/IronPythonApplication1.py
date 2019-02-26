#! /usr/bin/env python
# -*- coding: utf-8 -*-

from io import open
from conllu import parse_incr

#, encoding="utf-8"
#Windows-1251
sentences = []
data_file = open(r'C:\Users\dudnik\Documents\CLPFGLD\IronPythonApplication1\IronPythonApplication1\Отладочный текст.txt', "r")

#data_file = open(r'D:\Загрузки\UD_Ukrainian-IU-dev\UD_Ukrainian-IU-dev\uk_iu-ud-dev.conllu.txt', "r")

for tokenlist in parse_incr(data_file):
    sentences.append(tokenlist)

#['deprel']
print(sentences[0][0])

input()