explain analyze select * from randData
   where language='en';

--OUTPUT: randData
--"Seq Scan on randdata  (cost=0.00..1954.01 rows=98661 width=25) (actual time=0.026..26.054 rows=98642 loops=1)"
--"  Filter: (language = 'en'::text)"
--"  Rows Removed by Filter: 1359"
--"Planning time: 0.155 ms"
--"Execution time: 29.254 ms"

--====================================================================================================================

--explain analyze select * from randData_Indexed
--   where language='en';

--OUTPUT: randData_Indexed
--"Bitmap Heap Scan on randdata_indexed  (cost=10.55..556.55 rows=292 width=68) (actual time=23.393..40.877 rows=98642 loops=1)"
--"  Recheck Cond: (language = 'en'::text)"
--"  Heap Blocks: exact=704"
--"  ->  Bitmap Index Scan on index  (cost=0.00..10.48 rows=292 width=0) (actual time=23.232..23.232 rows=98642 loops=1)"
--"        Index Cond: (language = 'en'::text)"
--"Planning time: 13.359 ms"
--"Execution time: 44.120 ms"

