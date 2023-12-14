## tmp.py
text = 'съешь ещё этих мягких французских булок'

print(text[1]) #ъ

print(text[len(text)-1])  #к

print(text[-5]) #6

print(text[:]) # съешь ещё этих мягких французских булок

print(text[:2]) # съ

print(text[len(text)-2:]) # OK

print(text[2:9]) # ешь ещё

print(text[6:-18]) # ещё этих мягких

print(text[0:len(text):6]) # сеикакл

print(text[::6]) # сеикакл

text = text[2:9] + text[-5] + text[:2]  #-----