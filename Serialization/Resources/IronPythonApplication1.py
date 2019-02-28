#! /usr/bin/env python
# -*- coding: utf-8 -*-

from io import open
from conllu import parse_incr

sentences = []
data_file = open(r'Resources\Отладочный текст.txt', "r")

for tokenlist in parse_incr(data_file):
    sentences.append(tokenlist)