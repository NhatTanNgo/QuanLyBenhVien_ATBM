------------------------------------------------------------------
--- Dang nhap voi quyen SYS trong SQL Plus
--- Chay cac lenh sau:
--- alter system set audit_trail = db,extended scope = spfile;
--- shutdown immediate;
--- startup;
------------------------------------------------------------------
--- Sau do chay may lenh nay:

--- Bat audit tren 2 table nay
audit all on OT.BENHNHAN by access;
audit all on OT.NHANVIEN by access;

--- Thu truy van den bang BENHNHAN
select * from ot.benhnhan;

--- Xem ket qua audit
select username, owner, obj_name, action_name, sql_text from dba_audit_trail;