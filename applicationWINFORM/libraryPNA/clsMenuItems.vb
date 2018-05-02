'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports DevExpress
Imports DevExpress.XtraBars
Imports System.Windows.Forms
Public Class clsMenuItems
    Private frmMain As Object
    Private Sub HumanResource(ByRef oForm As Object)
        With oForm
            Dim mnuItemHR As New BarSubItem
            mnuItemHR.Name = "mnuItemHR"
            mnuItemHR.Id = .BarManager1.GetNewItemId()
            mnuItemHR.Caption = "Human resource"
            .mnuItems.AddItem(mnuItemHR)

            Dim mnuItemHRCountry As New BarButtonItem
            mnuItemHRCountry.Name = "mnuItemHRCountry"
            mnuItemHRCountry.Id = .BarManager1.GetNewItemId()
            mnuItemHRCountry.Caption = "Country"
            mnuItemHR.AddItem(mnuItemHRCountry)
            AddHandler mnuItemHRCountry.ItemClick, AddressOf onclick_mnuItemHRCountry

            Dim mnuItemHRCity As New BarButtonItem
            mnuItemHRCity.Name = "mnuItemHRCity"
            mnuItemHRCity.Id = .BarManager1.GetNewItemId()
            mnuItemHRCity.Caption = "City"
            mnuItemHR.AddItem(mnuItemHRCity)
            AddHandler mnuItemHRCity.ItemClick, AddressOf onclick_mnuItemHRCity

            Dim mnuItemHRDistrict As New BarButtonItem
            mnuItemHRDistrict.Name = "mnuItemHRDistrict"
            mnuItemHRDistrict.Id = .BarManager1.GetNewItemId()
            mnuItemHRDistrict.Caption = "District"
            mnuItemHR.AddItem(mnuItemHRDistrict)
            AddHandler mnuItemHRDistrict.ItemClick, AddressOf onclick_mnuItemHRDistrict

            Dim mnuItemHRReligion As New BarButtonItem
            mnuItemHRReligion.Name = "mnuItemHRReligion"
            mnuItemHRReligion.Id = .BarManager1.GetNewItemId()
            mnuItemHRReligion.Caption = "Religion"
            mnuItemHR.AddItem(mnuItemHRReligion)
            AddHandler mnuItemHRReligion.ItemClick, AddressOf onclick_mnuItemHRReligion

            Dim mnuItemHRNation As New BarButtonItem
            mnuItemHRNation.Name = "mnuItemHRNation"
            mnuItemHRNation.Id = .BarManager1.GetNewItemId()
            mnuItemHRNation.Caption = "Nationality"
            mnuItemHR.AddItem(mnuItemHRNation)
            AddHandler mnuItemHRNation.ItemClick, AddressOf onclick_mnuItemHRNation

            Dim mnuItemHRHospital As New BarButtonItem
            mnuItemHRHospital.Name = "mnuItemHRHospital"
            mnuItemHRHospital.Id = .BarManager1.GetNewItemId()
            mnuItemHRHospital.Caption = "Hospital"
            mnuItemHR.AddItem(mnuItemHRHospital)
            AddHandler mnuItemHRHospital.ItemClick, AddressOf onclick_mnuItemHRHospital

            Dim mnuItemHRSchool As New BarButtonItem
            mnuItemHRSchool.Name = "mnuItemHRSchool"
            mnuItemHRSchool.Id = .BarManager1.GetNewItemId()
            mnuItemHRSchool.Caption = "School"
            mnuItemHR.AddItem(mnuItemHRSchool)
            AddHandler mnuItemHRSchool.ItemClick, AddressOf onclick_mnuItemHRSchool

            Dim mnuItemHRCompany As New BarButtonItem
            mnuItemHRCompany.Name = "mnuItemHRCompany"
            mnuItemHRCompany.Id = .BarManager1.GetNewItemId()
            mnuItemHRCompany.Caption = "Company"
            mnuItemHR.AddItem(mnuItemHRCompany)
            AddHandler mnuItemHRCompany.ItemClick, AddressOf onclick_mnuItemHRCompany

            Dim mnuItemHRDepartment As New BarButtonItem
            mnuItemHRDepartment.Name = "mnuItemHRDepartment"
            mnuItemHRDepartment.Id = .BarManager1.GetNewItemId()
            mnuItemHRDepartment.Caption = "Department"
            mnuItemHR.AddItem(mnuItemHRDepartment)
            AddHandler mnuItemHRDepartment.ItemClick, AddressOf onclick_mnuItemHRDepartment

            Dim mnuItemHRJobtitle As New BarButtonItem
            mnuItemHRJobtitle.Name = "mnuItemHRJobtitle"
            mnuItemHRJobtitle.Id = .BarManager1.GetNewItemId()
            mnuItemHRJobtitle.Caption = "Jobtitle"
            mnuItemHR.AddItem(mnuItemHRJobtitle)
            AddHandler mnuItemHRJobtitle.ItemClick, AddressOf onclick_mnuItemHRJobtitle

            Dim mnuItemHRLevel As New BarButtonItem
            mnuItemHRLevel.Name = "mnuItemHRLevel"
            mnuItemHRLevel.Id = .BarManager1.GetNewItemId()
            mnuItemHRLevel.Caption = "Level"
            mnuItemHR.AddItem(mnuItemHRLevel)
            AddHandler mnuItemHRLevel.ItemClick, AddressOf onclick_mnuItemHRLevel

            Dim mnuItemHRCertificate As New BarButtonItem
            mnuItemHRCertificate.Name = "mnuItemHRCertificate"
            mnuItemHRCertificate.Id = .BarManager1.GetNewItemId()
            mnuItemHRCertificate.Caption = "Certificate"
            mnuItemHR.AddItem(mnuItemHRCertificate)
            AddHandler mnuItemHRCertificate.ItemClick, AddressOf onclick_mnuItemHRCertificate

            Dim mnuItemHROther As New BarSubItem
            mnuItemHROther.Name = "mnuItemHROther"
            mnuItemHROther.Id = .BarManager1.GetNewItemId()
            mnuItemHROther.Caption = "Others"
            mnuItemHR.AddItem(mnuItemHROther)

            Dim mnuItemHRSkillFavourite As New BarButtonItem
            mnuItemHRSkillFavourite.Name = "mnuItemHRSkillFavourite"
            mnuItemHRSkillFavourite.Id = .BarManager1.GetNewItemId()
            mnuItemHRSkillFavourite.Caption = "Skill favourite"
            mnuItemHROther.AddItem(mnuItemHRSkillFavourite)
            AddHandler mnuItemHRSkillFavourite.ItemClick, AddressOf onclick_mnuItemHRSkillFavourite

            Dim mnuItemHRTrainningTerm As New BarButtonItem
            mnuItemHRTrainningTerm.Name = "mnuItemHRTrainningTerm"
            mnuItemHRTrainningTerm.Id = .BarManager1.GetNewItemId()
            mnuItemHRTrainningTerm.Caption = "Trainning term"
            mnuItemHROther.AddItem(mnuItemHRTrainningTerm)
            AddHandler mnuItemHRTrainningTerm.ItemClick, AddressOf onclick_mnuItemHRTrainningTerm

            Dim mnuItemHRCommendDiscipline As New BarButtonItem
            mnuItemHRCommendDiscipline.Name = "mnuItemHRCommendDiscipline"
            mnuItemHRCommendDiscipline.Id = .BarManager1.GetNewItemId()
            mnuItemHRCommendDiscipline.Caption = "Commend discipline"
            mnuItemHROther.AddItem(mnuItemHRCommendDiscipline)
            AddHandler mnuItemHRCommendDiscipline.ItemClick, AddressOf onclick_mnuItemHRCommendDiscipline

            Dim mnuItemHRMarriageStatus As New BarButtonItem
            mnuItemHRMarriageStatus.Name = "mnuItemHRMarriageStatus"
            mnuItemHRMarriageStatus.Id = .BarManager1.GetNewItemId()
            mnuItemHRMarriageStatus.Caption = "Marriage status"
            mnuItemHROther.AddItem(mnuItemHRMarriageStatus)
            AddHandler mnuItemHRMarriageStatus.ItemClick, AddressOf onclick_mnuItemHRMarriageStatus

            Dim mnuItemHRFamilyRelationship As New BarButtonItem
            mnuItemHRFamilyRelationship.Name = "mnuItemHRFamilyRelationship"
            mnuItemHRFamilyRelationship.Id = .BarManager1.GetNewItemId()
            mnuItemHRFamilyRelationship.Caption = "Family relationship"
            mnuItemHROther.AddItem(mnuItemHRFamilyRelationship)
            AddHandler mnuItemHRFamilyRelationship.ItemClick, AddressOf onclick_mnuItemHRFamilyRelationship

            Dim mnuItemHRLaborContract As New BarButtonItem
            mnuItemHRLaborContract.Name = "mnuItemHRLaborContract"
            mnuItemHRLaborContract.Id = .BarManager1.GetNewItemId()
            mnuItemHRLaborContract.Caption = "Labor contract"
            mnuItemHROther.AddItem(mnuItemHRLaborContract)
            AddHandler mnuItemHRLaborContract.ItemClick, AddressOf onclick_mnuItemHRLaborContract

            Dim mnuItemHREmployee As New BarButtonItem
            mnuItemHREmployee.Name = "mnuItemHREmployee"
            mnuItemHREmployee.Id = .BarManager1.GetNewItemId()
            mnuItemHREmployee.Caption = "Employee"
            mnuItemHR.AddItem(mnuItemHREmployee)

            mnuItemHR.LinksPersistInfo.Item(7).BeginGroup = True
            mnuItemHROther.LinksPersistInfo.Item(5).BeginGroup = True
        End With
    End Sub
    Private Sub Documents(ByRef oForm As Object)
        With oForm
            Dim mnuItemDOC As New BarSubItem
            mnuItemDOC.Name = "mnuItemDOC"
            mnuItemDOC.Id = .BarManager1.GetNewItemId()
            mnuItemDOC.Caption = "Documents"
            .mnuItems.AddItem(mnuItemDOC)
        End With
    End Sub
    Private Sub Hotel(ByRef oForm As Object)
        With oForm
            Dim mnuItemHOTEL As New BarSubItem
            mnuItemHOTEL.Name = "mnuItemHOTEL"
            mnuItemHOTEL.Id = .BarManager1.GetNewItemId()
            mnuItemHOTEL.Caption = "Hotel"
            .mnuItems.AddItem(mnuItemHOTEL)

            Dim mnuItemHOTELIdentity As New BarButtonItem
            mnuItemHOTELIdentity.Name = "mnuItemHOTELIdentity"
            mnuItemHOTELIdentity.Id = .BarManager1.GetNewItemId()
            mnuItemHOTELIdentity.Caption = "Identity"
            mnuItemHOTEL.AddItem(mnuItemHOTELIdentity)
            AddHandler mnuItemHOTELIdentity.ItemClick, AddressOf onclick_mnuItemHOTELIdentity
        End With
    End Sub
    Private Sub Purchasing(ByRef oForm As Object)
        With oForm
            Dim mnuItemPU As New BarSubItem
            mnuItemPU.Name = "mnuItemPU"
            mnuItemPU.Id = .BarManager1.GetNewItemId()
            mnuItemPU.Caption = "Purchasing"
            .mnuItems.AddItem(mnuItemPU)

            Dim mnuItemPUCustomerType As New BarButtonItem
            mnuItemPUCustomerType.Name = "mnuItemPUCustomerType"
            mnuItemPUCustomerType.Id = .BarManager1.GetNewItemId()
            mnuItemPUCustomerType.Caption = "Customer type"
            mnuItemPU.AddItem(mnuItemPUCustomerType)
            AddHandler mnuItemPUCustomerType.ItemClick, AddressOf onclick_mnuItemPUCustomerType

            Dim mnuItemPUSupplierType As New BarButtonItem
            mnuItemPUSupplierType.Name = "mnuItemPUSupplierType"
            mnuItemPUSupplierType.Id = .BarManager1.GetNewItemId()
            mnuItemPUSupplierType.Caption = "Supplier type"
            mnuItemPU.AddItem(mnuItemPUSupplierType)
            AddHandler mnuItemPUSupplierType.ItemClick, AddressOf onclick_mnuItemPUSupplierType
        End With
    End Sub
    Private Sub Stock(ByRef oForm As Object)
        With oForm
            Dim mnuItemSTOCK As New BarSubItem
            mnuItemSTOCK.Name = "mnuItemSTOCK"
            mnuItemSTOCK.Id = .BarManager1.GetNewItemId()
            mnuItemSTOCK.Caption = "Stock"
            .mnuItems.AddItem(mnuItemSTOCK)
        End With
    End Sub
    Private Sub Accountant(ByRef oForm As Object)
        With oForm
            Dim mnuItemACC As New BarSubItem
            mnuItemACC.Name = "mnuItemACC"
            mnuItemACC.Id = .BarManager1.GetNewItemId()
            mnuItemACC.Caption = "Accountant"
            .mnuItems.AddItem(mnuItemACC)

            Dim mnuItemACCBank As New BarButtonItem
            mnuItemACCBank.Name = "mnuItemACCBank"
            mnuItemACCBank.Id = .BarManager1.GetNewItemId()
            mnuItemACCBank.Caption = "Bank"
            mnuItemACC.AddItem(mnuItemACCBank)
            AddHandler mnuItemACCBank.ItemClick, AddressOf onclick_mnuItemACCBank
        End With
    End Sub
    Public Sub InitialMenuItems(ByRef oForm As Object)
        HumanResource(oForm)
        Documents(oForm)
        Hotel(oForm)
        Purchasing(oForm)
        Stock(oForm)
        Accountant(oForm)
        If frmMain Is Nothing Then frmMain = oForm
    End Sub
#Region "HumanResource"
    Private Sub onclick_mnuItemHRCountry(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRCountry
        NewForm(frm)
        'frmMain.xtraTabbedMdiManager1.MdiParent = Nothing
    End Sub
    Private Sub onclick_mnuItemHRCity(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRCity
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRDistrict(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRDistrict
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRReligion(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRReligion
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRNation(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRNation
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRHospital(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRHospital
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRSchool(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRSchool
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRCompany(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRCompany
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRDepartment(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRDepartment
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRJobtitle(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRJobtitle
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRLevel(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRLevel
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRCertificate(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRCertificate
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRTrainningTerm(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRTrainningTerm
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRSkillFavourite(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRSkillFavourite
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRCommendDiscipline(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRCommendDiscipline
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRMarriageStatus(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRMarriageStatus
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRFamilyRelationship(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRFamilyRelationship
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemHRLaborContract(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHRLaborContract
        NewForm(frm)
    End Sub
#End Region
#Region "Documents"
#End Region
#Region "Hotel"
    Private Sub onclick_mnuItemHOTELIdentity(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmHOTELIdentity
        NewForm(frm)
    End Sub
#End Region
#Region "Purchasing"
    Private Sub onclick_mnuItemPUCustomerType(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmPUCustomerType
        NewForm(frm)
    End Sub
    Private Sub onclick_mnuItemPUSupplierType(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmPUSupplierType
        frm.MdiParent = frmMain
        frm.Show()
    End Sub
#End Region
#Region "Stock"

#End Region
#Region "Accountant"
    Private Sub onclick_mnuItemACCBank(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Dim frm As New frmACCBank
        NewForm(frm)
    End Sub
#End Region
End Class
