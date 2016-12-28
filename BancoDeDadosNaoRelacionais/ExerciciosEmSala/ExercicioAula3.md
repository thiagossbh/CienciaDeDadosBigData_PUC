* Utilizando as funções de mapReduce do mongo, conte o número de palavras que terminam em ar, er, ir, or, ur.

```javascript
show dbs
```
```bash
dbAula2     0.000GB
dbInfoSala  0.000GB
local       0.000GB
nosqlclass  0.015GB
```
```javascript
use nosqlclass
```
```bash
switched to db nosqlclass
```

```javascript
var map = function()
{
	emit(this.text.substring(this.text.length-2,this.text.length),1);
}

var reduce = function(key, values)
{
	return Array.sum(values);
}

db.Vocabulary.mapReduce(map,reduce,{query:
{
	text:  /((ar)|(er)|(ir))$/
}
 , out:"resultado"})
```
```javascript
db.resultado.find()
```
```bash
{ "_id" : "ar", "value" : 2950 }
{ "_id" : "er", "value" : 2342 }
{ "_id" : "ir", "value" : 554 }
```


* Utilizando as funções de mapReduce do mongo, conte o total de cada caracter existente no vocabulario. Por exemplo: aula -> a:2, u:1, l:1.

```javascript
var map = function(){
	if (this.text == undefined) return; 
	for (var letra = 0; letra < this.text.length; letra++){ 
		  emit(this.text[letra], 1);
	}
}

var reduce = function(key, value){
	return Array.sum(value);
}

db.Vocabulary.mapReduce(map, reduce, {query:{}, out:"Resultado"})

db.Resultado.find().pretty()
```
