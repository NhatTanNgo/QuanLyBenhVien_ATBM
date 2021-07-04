--- Them policy fine-grained audit vao
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_QLBV',
   object_name        => 'PHIEUYEUCAUDICHVU',
   policy_name        => 'chk_kqdv_pycdv',
   enable             =>  TRUE,
   statement_types    => 'INSERT, UPDATE, SELECT, DELETE',
   audit_column       => 'KETQUADICHVU',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_QLBV',
   object_name        => 'PHIEUKHAMBENH',
   policy_name        => 'chk_klbs_pkb',
   enable             =>  TRUE,
   statement_types    => 'INSERT, UPDATE, SELECT, DELETE',
   audit_column       => 'KETLUANCUABACSI',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--- Truy van de test ----
select ketquadichvu from DBA_QLBV.PHIEUYEUCAUDICHVU;
select ketluancuabacsi from DBA_QLBV.PHIEUKHAMBENH;

---Kiem tra ket qua audit
SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM SYS.FGA_LOG$;

----- TEMPLATE Xoa Policy -----
---BEGIN
---DBMS_FGA.DROP_POLICY(
---  object_schema      => 'DBA_QLBV',
---  object_name        => 'PHIEUYEUCAUDICHVU',
---  policy_name        => 'chk_kqdv_pycdv');
---END;
---/
