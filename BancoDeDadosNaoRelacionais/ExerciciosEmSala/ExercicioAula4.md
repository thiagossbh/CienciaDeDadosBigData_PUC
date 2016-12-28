```javascript
Faça uma pesquisa simples na coleção Vocabulary pelo termo “feliz” no campo text e diga:
```
```
A) Número de documentos que foi escaneado
```
```batch
db.Vocabulary.find({"text":"feliz"}).explain({"executionStats":1})
```
"totalDocsExamined" : 291214
```
B) Tempo que levou para fazer a consulta
```
"executionTimeMillis" : 73
```
C) Crie um índice simples no campo text
```
db.Vocabulary.createIndex({"text" :1})

```
D) Número de documentos que foi escaneado
```
"totalDocsExamined" : 1,

```
E) Tempo que levou para fazer a consulta
```
"executionTimeMillis" : 1,
