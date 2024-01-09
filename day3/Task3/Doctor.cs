public class Doctor
{
    private string FullName;
    private string Specialty;
    private int Experience;

    public string fullName { get{return FullName;} set{FullName = value;} }
    public string specialty { get{return Specialty;} set{Specialty = value;} }
    public int experience { get{return Experience;} set{Experience = value;} }
    public Doctor() {}
    public Doctor(string name,string specialty)
    {
        fullName = name;
        this.specialty = specialty; 
    }
    public Doctor(string name,string specialty,int experience)
    {
        fullName = name; 
        this.specialty = specialty;
        this.experience = experience;       
    }
    public string TreatPatient(string name)
    {
        return $"{fullName} is treating a patient named {name}.";
    }
    public string PerformMedicalExamination(string patientName) 
    {
        return $"{fullName} is performing a medical examination on {patientName}.";
    }
    public string PrescribeMedication(string patientName, string medication) 
    {
        return $"{fullName} prescribes {medication} for {patientName}.";
    }
    public void SetExperience(int years) 
    {
        experience = years;
    }
    public int GetExperience()
    {
        return experience;
    } 
}