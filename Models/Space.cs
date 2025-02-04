public class Space {
    public PieceEnum Piece {get; protected set;}

    public void SetPiece( PieceEnum piece){
        Piece = piece;
    }
}