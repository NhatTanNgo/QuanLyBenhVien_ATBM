------------------------------------------------------------------
--- Dang nhap voi quyen SYS trong SQL Plus
--- Chay cac lenh sau:
--- alter system set audit_trail = db,extended scope = spfile;
--- shutdown immediate;
--- startup;
------------------------------------------------------------------
--- Sau do chay may lenh nay:

--- Bat audit tren 2 table nay
audit all on DBA_QLBV.BENHNHAN by access;
audit all on DBA_QLBV.NHANVIEN by access;

--- Thu truy van den bang BENHNHAN
select * from DBA_QLBV.benhnhan;

--- Xem ket qua audit
select username, owner, obj_name, action_name, sql_text from dba_audit_trail;