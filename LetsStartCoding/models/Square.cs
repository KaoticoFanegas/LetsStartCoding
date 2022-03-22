namespace TrackglobeCampus.OneOOne.Models{
    public class Square{
        public Point StartingPoint{get; set;} = null;
        public Point EndingPoint{get; set;} = null;

        public double GetArea(){
            return (this.EndingPoint.X - this.StartingPoint.X) * (this.EndingPoint.Y - this.StartingPoint.Y);
        }
    }
}